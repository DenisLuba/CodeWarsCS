namespace CodeWars.Tests;

[TestFixture]
internal class DerectionsResuctionTest
{
    [TestCase(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" }, new string[] { "WEST" })]
    [TestCase(new string[] { "NORTH", "WEST", "SOUTH", "EAST" }, new string[] { "NORTH", "WEST", "SOUTH", "EAST" })]
    public void Test2(string[] input, string[] expected) => Assert.That(DirectionsReduction.DirReduction(input), Is.EqualTo(expected));
}
