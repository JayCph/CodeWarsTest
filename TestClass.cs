using NUnit.Framework;

namespace CodeWarsTest._8kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(21, Kata.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(-21, Kata.ArrayPlusArray(new int[] { -1, -2, -3 }, new int[] { -4, -5, -6 }));
            Assert.AreEqual(15, Kata.ArrayPlusArray(new int[] { 0, 0, 0 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(2100, Kata.ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }));

        }
    }
}