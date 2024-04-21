namespace CodeWars.Test
{
    [TestFixture]
    public class RemoveExclamationMarksKataTest
    {

        [TestCase("Hello world!", "Hello world")]
        [TestCase("!!!", "")]
        [TestCase("Hello", "Hello")]
        [TestCase("Hello!!world", "Helloworld")]
        public void RemoveExclamationMarksTest(string s, string result)
        {
            Assert.That(result, Is.EqualTo(RemoveExclamationMarksKata.RemoveExclamationMarks(s)));
        }
    }
}
