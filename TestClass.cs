using NUnit.Framework;

namespace CodeWarsTest._8kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool FixedTest(int[] arr, int num)
        {
            return Kata.BetterThanAverage(arr, num);
        }
    }
}