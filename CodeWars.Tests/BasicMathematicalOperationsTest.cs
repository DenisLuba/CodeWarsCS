namespace CodeWars.Tests;

internal class BasicMathematicalOperationsTest
{
    [TestCase('+', 4, 7, ExpectedResult = 11.0)]
    [TestCase('-', 15, 18, ExpectedResult = -3.0)]
    [TestCase('*', 5, 5, ExpectedResult = 25.0)]
    [TestCase('/', 49, 7, ExpectedResult = 7)]
    public double Test(char op, int a, int b) => BasicMathematicalOperations.BasicOp(op, a, b);

    [TestCase(' ', 1, 2)]
    public void TestException(char op, int a, int b)
    {
        Assert.That(() => BasicMathematicalOperations.BasicOp(op, a, b), Throws.ArgumentException);
    }
}