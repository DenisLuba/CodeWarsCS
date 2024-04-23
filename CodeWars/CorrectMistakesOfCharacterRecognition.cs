using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CorrectMistakesOfCharacterRecognition
    {
        public static string Correct(string text)
            => text.Replace('5', 'S').Replace('1', 'I').Replace('0', 'O');
    }
}
