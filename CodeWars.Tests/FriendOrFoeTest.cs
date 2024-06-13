using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    internal class FriendOrFoeTest
    {
        static readonly string[] names_1 = ["Kate", "Bob"];
        static readonly IEnumerable<string> expected_1 = ["Kate"];

        static readonly string[] names_2 = [""];
        static readonly IEnumerable<string> expected_2 = [];

        static readonly string[] names_3 = ["Tom", "Bob"];
        static readonly IEnumerable<string> expected_3 = [];

        private static IEnumerable<TestCaseData> testCases2
        {
            get
            {
                yield return new TestCaseData([names_1]).Returns(expected_1);
                yield return new TestCaseData([names_2]).Returns(expected_2);
                yield return new TestCaseData([names_3]).Returns(expected_3);
            }
        }

        [Test, TestCaseSource(nameof(testCases2))]
        public IEnumerable<string> Test(string[] names) => FriendOrFoeClass.FriendOrFoe(names);
    }
}
