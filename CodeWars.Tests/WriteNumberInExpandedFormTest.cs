namespace CodeWars.Tests;

[TestFixture]
internal class WriteNumberInExpandedFormTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(WriteNumberInExpandedForm.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(WriteNumberInExpandedForm.ExpandedForm(42), Is.EqualTo("40 + 2"));
            Assert.That(WriteNumberInExpandedForm.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
        });
    }
}
