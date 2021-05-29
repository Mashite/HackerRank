using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            long result = Result.candies(n, arr);

            Console.WriteLine(result);
        }
    }

    class Result
    {

        /*
         * Complete the 'candies' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY arr
         */

        public static long candies(int n, List<int> arr)
        {
            long result = 0;
            int[] arrLeft = new int[arr.Count];
            int[] arrRight = new int[arr.Count];
            arrLeft[0] = 1;
            arrRight[arr.Count - 1] = 1;
            for (int i=1; i<arr.Count;i++)
            {
                if (arr[i] > arr[i - 1]) arrLeft[i] = arrLeft[i - 1] + 1;
                else arrLeft[i] = 1;

            }

            for(int j=arr.Count-2; j==0;j--)
            {
                if (arr[j] > arr[j + 1]) arrRight[j] = arrRight[j + 1] + 1;
                else arrRight[j] = 1;
            }

            for(int i=0;i<arr.Count;i++)
            {
                result += Math.Max(arrLeft[i], arrRight[i]);
            }

            return result;
        }

    }
}
