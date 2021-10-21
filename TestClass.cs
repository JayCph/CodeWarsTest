using NUnit.Framework;

namespace CodeWarsTest._8kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return Kata.PositiveSum(arr);
        }
    }
}