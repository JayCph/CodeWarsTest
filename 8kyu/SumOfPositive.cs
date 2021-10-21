using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest._8kyu
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            var positiveNumbers = arr.Where(x => x > 0).ToList();

            {
                int sum = positiveNumbers.Sum();
                return (sum);
            }
        }
    }
}