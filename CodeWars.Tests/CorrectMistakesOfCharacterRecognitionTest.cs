using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    internal class CorrectMistakesOfCharacterRecognitionTest
    {
        [TestCase("L0ND0N", "LONDON")]
        [TestCase("DUBL1N", "DUBLIN")]
        [TestCase("51NGAP0RE", "SINGAPORE")]
        [TestCase("BUDAPE5T", "BUDAPEST")]
        [TestCase("PAR15", "PARIS")]

        public static void CorrectTest(string input, string output)
        {
            Assert.That(CorrectMistakesOfCharacterRecognition.Correct(input), Is.EqualTo(output));
        }
    }
}
