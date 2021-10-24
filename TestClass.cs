using NUnit.Framework;

namespace CodeWarsTest._8kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    public static class RentalCarTests
    {

        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(RentalCar.RentalCarCost(1), 40);
            testing(RentalCar.RentalCarCost(3), 100);
            testing(RentalCar.RentalCarCost(7), 230);
        }
    }
}