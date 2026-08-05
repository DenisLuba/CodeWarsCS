namespace CodeWars;

public class LinearEquations
{
    public static string Solve(string input)
    {
        var matrix = GetMatrix(input);
    }

    static Fraction[][] SolveByGauss(Fraction[][] matrix)
    {
        int rows = matrix[0].Length - 1;

        // неправильно. Надо поправить, добавить еще проходку внутри
        //foreach (var row in matrix)
        //{
        //    var x = row[0];

        //    if (x.Numerator != x.Denominator || x.Numerator != 0)
        //    {
        //        var factor = new Fraction(x.Denominator, x.Numerator);

        //        foreach (var i in row)
        //        {
        //            i.Numerator *= factor.Numerator;
        //            i.Denominator *= factor.Denominator;
        //        }
        //    }
        //}
    }

    static Fraction[][] GetMatrix(string input)
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

        public override string ToString()
        {
            if (Denominator == 1) return Numerator.ToString();
            return $"{Numerator}/{Denominator}";
        }
    }
}
