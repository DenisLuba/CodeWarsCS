using System;
using System.Text;

namespace CodeWars;

public class LinearEquations
{
    public static string Solve(string input)
    {
        try
        {
            var matrix = GetMatrixFromString(input);
            SetEchelonFormMatrix(matrix);

            var results = SolveByGauss(matrix);

            return GetStringFromMatrix(results);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "NONE";
        }
    }

    static Fraction[][] SolveByGauss(Fraction[][] matrix)
    {
        //SetEchelonFormMatrix(matrix);
        return GetResults(matrix);
    }

    static int GetLeadingZeros(Fraction[] fractions)
    {
        var leadingZeros = 0;
        foreach (Fraction fraction in fractions)
        {
            if (fraction == 0) leadingZeros++;
            else break;
        }
        return leadingZeros;
    }

    static Fraction[] GetSumOfEquations(Fraction[] equation1, Fraction[] equation2, int i)
    {
        if (equation1.Length != equation2.Length)
        {
            throw new ArgumentException("Equations must have the same length.");
        }
        i = i >= equation1.Length - 1
            ? equation1.Length - 2 >= 0 ? equation1.Length - 2 : 0
            : i;

        var result = new Fraction[equation1.Length];
        var factorFraction2 = equation1[i];
        var factorFraction1 = equation2[i];

        for (int j = 0; j < equation1.Length; j++)
        {
            result[j] = equation2[j] * factorFraction2 - equation1[j] * factorFraction1;
        }
        return result;
    }

    static void SetEchelonFormMatrix(Fraction[][] matrix)
    {
        Array.Sort(matrix, (equation1, equation2) => GetLeadingZeros(equation1).CompareTo(GetLeadingZeros(equation2)));
        for (int i = 0; i < matrix.Length - 1; i++)
        {
            for (int j = i + 1; j < matrix.Length; j++)
            {
                //if (GetLeadingZeros(matrix[i]) == GetLeadingZeros(matrix[j]))
                //{
                //    continue;
                //}
                matrix[j] = GetSumOfEquations(matrix[i], matrix[j], GetLeadingZeros(matrix[i]));
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
        CheckResult(results);
        return results;
    }

    static void CheckResult(Fraction[][] results)
    {
        for (int i = 0; i < results.Length; i++)
        {
            if (results[i] is null)
            {
                results[i] = new Fraction[results.Length + 1];

                for (int j = 0; j < results[i].Length; j++)
                {
                    results[i][j] = new Fraction();
                    if (j == i)
                    {
                        results[i][j].Numerator = 1;
                    }
                }
                continue;
            }

            for (int j = 0; j < results[i].Length; j++)
            {
                if (results[i][j] is null)
                {
                    results[i][j] = new Fraction();
                }
            }
        }
    }

    static void ExpressVariable(Fraction[] equation, Fraction[][] results)
    {
        for (int i = 0; i < equation.Length; i++)
        {
            if (equation[i] is null)
            {
                equation[i] = new Fraction();
            }
        }

        var valuesNumber = equation.Length - 1; // количество переменных
        int xiResult = 0; // переменная, которую будем искать
        int xiFree = 0; // переменные, через, которые будем выражать искомую переменную

        // ищем первый ненулевой элемент в строке, он же является искомой переменной с индексом xiFree
        while (xiFree < valuesNumber && equation[xiFree] == 0) xiFree++;
        xiResult = xiFree;
        xiFree++;
        if (xiResult >= valuesNumber)
        {
            // если в строке все коэффициенты при переменных равны нулю, то 
            // проверяем, равен ли свободный член нулю. Если нет, то уравнение не имеет смысла
            if (equation[valuesNumber] != 0)
            {
                throw new InvalidOperationException("The equation has no solution.");
            }

            return;
        }

        // переносим все члены, кроме искомого xi, в правую часть уравнения 
        // (т.е. в столбцы свободных членов) и делим на коэффициент при искомой переменной (в левой части уравнения)
        for (int i = xiFree; i < valuesNumber; i++)
        {
            equation[i] /= -equation[xiResult];
        }
        equation[valuesNumber] /= equation[xiResult];

        equation[xiResult] = new Fraction(); // обнуляем коэффициент при искомой переменной, т.к. она теперь в правой части уравнения

        // если мы выводим значение для последней в списке искомой переменной, 
        // то в результаты записываем уже найденное для нее значение
        if (xiResult == results.Length - 1)
        {
            // упростим все дроби
            for (int i = xiResult + 1; i < equation.Length; i++)
            {
                Fraction.Reduce(equation[i]);
            }
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

                for (int j = 0; j < equation.Length; j++) results[xiFree][j] = new Fraction();
                results[xiFree][xiFree].Numerator = 1;
                continue;
            }

            var isUnknown = true;
            for (int i = 0; i < results[xiFree].Length; i++)
            {
                isUnknown = (results[xiFree][i] == 0 && xiFree != i)
                    || (results[xiFree][i] == 1 && xiFree == i);
                if (!isUnknown) break;
            }
            if (isUnknown) continue;

            var coefficients = equation[xiFree];
            if (coefficients == 0) continue;

            // если в матрице результатов уже есть значения для свободных переменных, то подставляем их в уравнение
            // т.е. умножаем коэффициент известной свободной переменной на её значение в матрице результатов 
            // и складываем в столбец свободные члены этой известной переменной со свободными членами текущего уравнения
            for (int xj = xiFree + 1; xj < equation.Length; xj++)
            {
                equation[xj] += results[xiFree][xj] * coefficients;
            }

            equation[xiFree] = new Fraction();
        }

        // упростим все дроби
        for (int i = xiResult + 1; i < equation.Length; i++)
        {
            Fraction.Reduce(equation[i]);
        }

        results[xiResult] = equation;
    }

    static Fraction[][] GetMatrixFromString(string input)
    {
        var lines = input.Split(['\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
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
        var output = new StringBuilder();
        if (results.Length == 0 || results[0].Length == 0) return string.Empty;

        string AppendRow(int k, out bool isZero)
        {
            var zeroNumber = 0;
            var expression = new StringBuilder();
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i][k] is null)
                    results[i][k] = new Fraction();

                if (results[i][k].Numerator == 0)
                {
                    zeroNumber++;
                }

                var z = i == 0 ? $"({results[i][k]}" : $"; {results[i][k]}";
                expression.Append(z);
            }
            isZero = zeroNumber == results.Length;

            expression.Append(")");
            return expression.ToString();
        }

        var start = AppendRow(results[0].Length - 1, out bool _);
        if (!string.IsNullOrEmpty(start)) output.Append(start);
        
        var end = new StringBuilder();

        for (int i = 0, k = 0; i < results[0].Length - 1; i++, k++)
        {
            var expression = AppendRow(i, out bool isZero);
            if (isZero)
            {
                k--;
                continue;
            }
            if (!string.IsNullOrEmpty(expression))
            {
                var s = k == 0 ? $"q{k + 1} * " : $" + q{k + 1} * ";
                end.Append(s).Append(expression);
            }
        }
        if (!string.IsNullOrEmpty(end.ToString()))
        {
            output.Append(" + ").Append(end);
        }
        return output.ToString();
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

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero fraction.");
            }
            var result = new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            if (result.Denominator < 0)
            {
                result.Numerator = -result.Numerator;
                result.Denominator = -result.Denominator;
            }
            return result;
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

        public static bool operator ==(double a, Fraction b)
        {
            return a == ((double)b.Numerator) / b.Denominator;
        }

        public static bool operator !=(Fraction a, double b)
        {
            return !(a == b);
        }

        public static bool operator !=(double a, Fraction b)
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
            f.Numerator /= gcd;
            f.Denominator /= gcd;
            if (f.Denominator < 0)
            {
                f.Numerator = -f.Numerator;
                f.Denominator = -f.Denominator;
            }
            return f;
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
