namespace CodeWars
{
    public static class GradeBook
    {
        public static char GetGrade(int n1, int n2, int n3)
            => Task.Run(() => GetChar(GetAverage(n1, n2, n3).Result).Result).Result;

        static Func<int, Task<char>> GetChar = async i
            => await Task.Run(() => i.ToChar());

        async static Task<int> GetAverage(params int[] nums)
        {
            return await Task.Run(() => (int) nums.Average());
        }

        static char ToChar(this int n) => n switch
        {
            >= 90 and <= 100 => 'A',
            >= 80 and < 90 => 'B',
            >= 70 and < 80 => 'C',
            >= 60 and < 70 => 'D',
            >= 0 and < 60 => 'F',
            _ => ' '
        };
    }
}
