namespace CodeWars;

public class LinearEquations
{
    public static string Solve(string input)
    {
        var matrix = GetMatrixFromString(input);
    }

    static Fraction[][] SolveByGauss(Fraction[][] matrix)
    {
        SetEchelonFormMatrix(matrix);
    }

    static void SetEchelonFormMatrix(Fraction[][] matrix)
    {
        var factorFraction = new Fraction();

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

    static Fraction[][] GetResult(Fraction[][] matrix)
    {
        var valuesNumber = matrix[0].Length - 1;

        var result = new Fraction[valuesNumber][];
        var coefficient = new Fraction();

        // обратный ход метода Гаусса
        for (int i = matrix.Length - 1; i >= 0; i--)
        {
            var equation = matrix[i];

            for (int xi = 0; xi < valuesNumber; xi++)
            {
                // ищем первый ненулевой элемент в строке, он же является искомой переменной с индексом xi и множителем, равным 1
                if (equation[xi] == 0) continue;

                for (int xFree = xi + 1; xFree < valuesNumber; xFree++)
                {
                    // переносим все члены, кроме искомого xi, в правую часть уравнения (т.е. в столбцы свободных членов)
                    equation[xFree] *= -1;
                    coefficient = equation[xFree];

                    if (i == matrix.Length - 1) continue;

                    if (result[xFree] is null || result[xFree].Length == 0)
                    {
                        result[xFree] = new Fraction[matrix[i].Length];
                        for (int j = 0; j < result[xFree].Length; j++)
                        {
                            result[xFree][j] = new Fraction();
                            if (j == xFree)
                            {
                                result[xFree][j].Numerator = 1;
                            }
                        }
                        continue;
                    }

                    // если в матрице результатов уже есть значения для свободных переменных, то подставляем их в уравнение
                    // т.е. умножаем коэффициент известной свободной переменной на её значение в матрице результатов 
                    // и складываем в столбец свободные члены этой известной переменной со свободными членами текущего уравнения
                    for (int xj = xFree + 1; xj < equation.Length - 1; xj++)
                    {
                        equation[xj] += (result[xFree][xj] * coefficient);
                    }


                }

                result[i] = matrix[i];
                result[i][xi].Numerator = 0;




            }


        }
    }

    static void ExpressVariable(Fraction[] equation, Fraction[][] results)
    {
        var valuesNumber = equation.Length - 1;
        var coefficient = new Fraction();
        int xi = 0;

        // ищем первый ненулевой элемент в строке, он же является искомой переменной с индексом xi и множителем, равным 1
        while (xi < valuesNumber || equation[xi] == 0) xi++;
        // переносим все члены, кроме искомого xi, в правую часть уравнения (т.е. в столбцы свободных членов)
        for (int i = xi + 1; i < valuesNumber; i++) equation[i] *= -1;

        if (results.Length - 1 == xi)
        {
            results[xi] = equation;
            return;
        }

        for (; xi < valuesNumber; xi++)
        {
            if (results.Length - 1 == xi) continue;

            if (results[xi] is null || results[xi].Length == 0)
            {
                results[xi] = new Fraction[equation.Length];

                for (int j = 0; j < valuesNumber + 1; j++)
                {
                    results[xi][j] = new Fraction();
                    if (j == xi)
                    {
                        results[xi][j].Numerator = 1;
                    }
                }
                continue;
            }

            // если в матрице результатов уже есть значения для свободных переменных, то подставляем их в уравнение
            // т.е. умножаем коэффициент известной свободной переменной на её значение в матрице результатов 
            // и складываем в столбец свободные члены этой известной переменной со свободными членами текущего уравнения
            for (int xj = xi + 1; xj < equation.Length - 1; xj++)
            {
                equation[xj] += (results[xi][xj] * coefficient);
            }


        }

        results[i] = matrix[i];
        results[i][xi].Numerator = 0;





    }
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

    public static Fraction Reduce(Fraction f)
    {
        int gcd = GetGCD(f.Numerator, f.Denominator);
        return new Fraction(f.Numerator / gcd, f.Denominator / gcd);
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
