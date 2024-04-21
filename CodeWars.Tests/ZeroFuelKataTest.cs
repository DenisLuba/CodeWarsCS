namespace CodeWars.Test
{
    [TestFixture]
    internal class ZeroFuelKataTest
    {
        [TestCase(true, 50u, 25u, 2u)]
        [TestCase(false, 100u, 50u, 1u)]

        public static void ZeroFuelTest(bool result, uint distanceToPump, uint mpg, uint fuelLeft)
        {
            Assert.That(result, Is.EqualTo(ZeroFuelKata.ZeroFuel(distanceToPump, mpg, fuelLeft)));
        }
    }
}
