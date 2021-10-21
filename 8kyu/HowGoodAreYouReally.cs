using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest._8kyu
{
    public class Kata
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int len = ClassPoints.Length;
            int sum = ClassPoints.Sum();
            double avg = 0;

            avg = (double)sum / len;

            if (YourPoints > avg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //[TestFixture]
    //public class Tests
    //{
    //    [Test]
    //    [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
    //    [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
    //    [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
    //    public static bool FixedTest(int[] arr, int num)
    //    {
    //        return Kata.BetterThanAverage(arr, num);
    //    }
    //}
}
