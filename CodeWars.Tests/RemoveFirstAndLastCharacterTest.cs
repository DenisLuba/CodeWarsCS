using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test
{
    [TestFixture]
    internal class RemoveFirstAndLastCharacterTest
    {
        [TestCase("loquen", "eloquent")]
        [TestCase("ountr", "country")]
        [TestCase("erso", "person")]
        [TestCase("lac", "place")]
        [TestCase("", "ok")]
        public void Test(string expected, string input)
        {
            Assert.That(RemoveFirstAndLastCharacter.Remove_char(input), Is.EqualTo(expected));
        }
    }
}
