namespace CodeWars;

public class LinearEquations
{
    public static string Solve(string input)
    {
        var matrix = GetMatrixFromString(input);
        var results = SolveByGauss(matrix);
        return GetStringFromMatrix(results);
    }

    static Fraction[][] SolveByGauss(Fraction[][] matrix)
    {
        SetEchelonFormMatrix(matrix);
        return GetResults(matrix);
    }

    static void SetEchelonFormMatrix(Fraction[][] matrix)
    {
        var factorFraction = new Fraction();

        // создаем ступенчатую структуру системы линейных уравнений 
        // с коэффициентом, равным 1, для каждой первой переменной в этой лестнице
        for (int k = 0; k < matrix.Length && k < matrix[0].Length - 1; k++)
        {
            for (int i = k; i < matrix.Length; i++)
            {
                factorFraction.Numerator = matrix[i][k] > 0
                    ? matrix[i][k].Denominator
                    : -matrix[i][k].Denominator;
                factorFraction.Denominator = Math.Abs(matrix[i][k].Numerator);

                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] *= factorFraction;
                }
            }

            if (k == 0) continue;

            for (int i = k; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] = matrix[i][j] - matrix[k - 1][j];
                }
            }
        }
    }

    static Fraction[][] GetResults(Fraction[][] matrix)
    {
        var valuesNumber = matrix[0].Length - 1;

        var results = new Fraction[valuesNumber][];

        // обратный ход метода Гаусса
        for (int i = matrix.Length - 1; i >= 0; i--)
        {
            ExpressVariable(matrix[i], results);
        }

        return results;
    }

    static void ExpressVariable(Fraction[] equation, Fraction[][] results)
    {
        var valuesNumber = equation.Length - 1;
        int xiResult = 0;
        int xiFree = 0;

        // ищем первый ненулевой элемент в строке, он же является искомой переменной с индексом xi и множителем, равным 1
        for (; equation[xiFree] == 0 && xiFree < valuesNumber; xiFree++)
        {
            xiResult = xiFree;
        }
        
        // переносим все члены, кроме искомого xi, в правую часть уравнения 
        // (т.е. в столбцы свободных членов)
        for (int i = xiFree + 1; i < valuesNumber; i++) equation[i] *= -1;

        // если мы выводим значение для последней в списке искомой переменной, 
        // то в результаты записываем уже найденное для нее значение
        if (xiResult == results.Length - 1)
        {
            results[xiResult] = equation;
            return;
        }

        // если мы выводим не последнюю переменную из списка переменных, 
        // то подставляем во все свободные переменные уже найденные ранее значения
        for (; xiFree < valuesNumber; xiFree++)
        {
            // если значение для переменной еще не присвоено, 
            // то записываем в список переменных саму эту переменную.
            // Т.е. ее коэффициент равен 1, а остальные коэффициенты равны 0.
            // И переходим дальше к следующей переменной
            if (results[xiFree] is null || results[xiFree].Length == 0)
            {
                results[xiFree] = new Fraction[equation.Length];

                for (int j = 0; j < equation.Length; j++)
                {
                    results[xiFree][j] = new Fraction();
                    if (j == xiFree)
                    {
                        results[xiFree][j].Numerator = 1;
                    }
                }
                continue;
            }

            // если в матрице результатов уже есть значения для свободных переменных, то подставляем их в уравнение
            // т.е. умножаем коэффициент известной свободной переменной на её значение в матрице результатов 
            // и складываем в столбец свободные члены этой известной переменной со свободными членами текущего уравнения
            for (int xj = xiFree + 1; xj < equation.Length - 1; xj++)
            {
                equation[xj] += results[xiFree][xj] * equation[xiFree];
            }

            // само значение переменной в уравнении приравниваем нулю 
            // после того, как мы ее подменили известным для нее значением,
            // которое выражено следующими в списке переменными:
            // Например, для x2 = a * x3 + b * x4 + c * x5 ... :
            // x2 = 0 * x0 ; 0 * x1 ; 0 * x2 ; a * x3 ; b * x4 ; c * x5 ...
            equation[xiFree].Numerator = 0;
            equation[xiFree].Denominator = 1;
        }

        // упростим все дроби
        for (int i = xiFree; i < equation.Length; i++)
        {
            Fraction.Reduce(equation[i]);
        }
        
        results[xiResult] = equation;
    }

    static Fraction[][] GetMatrixFromString(string input)
    {
        var lines = input.Split('\n', 'r', StringSplitOptions.RemoveEmptyEntries);
        Fraction[][] matrix = new Fraction[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            var row = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            matrix[i] = new Fraction[row.Length];

            for (int j = 0; j < row.Length; j++)
            {
                var numbers = row[j].Split('/', StringSplitOptions.RemoveEmptyEntries);
                if (numbers.Length > 0 && int.TryParse(numbers[0], out var numerator))
                {
                    matrix[i][j] = numbers.Length > 1 && int.TryParse(numbers[1], out var denominator)
                        ? new Fraction(numerator, denominator)
                        : new Fraction(numerator);
                }
            }
        }

        return matrix;
    }

    static string GetStringFromMatrix(Fraction[][] results)
    {
        var equations = new Fraction[results.Length][];
        var result = new StringBuilder();

        for (int i = 0; i < results.Length; i++)
        {
            // перенесем последний коэффициент, который стоит без переменной (просто число),
            // в начало решения уравнения, т.е. этот коэффициент будет иметь индекс 0, а дальше 
            // коэффициенты будут стоять при искомых переменных:
            // a + b * x0 + c * x1 + d * x2 ...
            var equation = new Fraction[results[i].Length];
            equation[0] = results[i][results[i].Length - 1];
            for (int j = 0; j < results[i].Length - 2; j++)
            {
                equation[j + 1] = results[i][j];
            }
        }
    }

    class Fraction(int numerator = 0, int denominator = 1)
    {
        public int Numerator { get; set; } = numerator;
        public int Denominator { get; set; } = denominator == 0 ? throw new ArgumentException("Denominator cannot be zero") : denominator;

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a.Numerator * b, a.Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f)
        {
            return new Fraction(-f.Numerator, f.Denominator);
        }

        public static bool operator ==(Fraction a, double b)
        {
            return a.Numerator / a.Denominator == b;
        }

        public static bool operator !=(Fraction a, double b)
        {
            return !(a == b);
        }

        public static bool operator <(Fraction a, double b)
        {
            return a.Numerator / a.Denominator < b;
        }

        public static bool operator >(Fraction a, double b)
        {
            return a.Numerator / a.Denominator > b;
        }

        public static void Reduce(Fraction f)
        {
            int gcd = GetGCD(f.Numerator, f.Denominator);
            f.Numerator /= gcd;
            f.Denominator /= gcd;
        }

        static int GetGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (Denominator == 1) return Numerator.ToString();
            return $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction other)
            {
                var reducedThis = Reduce(this);
                var reducedOther = Reduce(other);
                return reducedThis.Numerator == reducedOther.Numerator && reducedThis.Denominator == reducedOther.Denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }
    }
}
