namespace CodeWars.Tests;

[TestFixture]
internal class IsThisTriangleTest
{
    [Test]
    [Order(1)]
    public void IsTriangle_ValidPositiveNumbers_ReturnsTrue()
    {
        Assert.That(IsThisTriangle.IsTriangle(5, 7, 10), Is.True);
    }
}
