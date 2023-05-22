using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests.Tests
{
    internal class MissingInteger
    {
        /*
            Write a function:
            class Solution { public int solution(int[] A); }
            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            Given A = [1, 2, 3], the function should return 4.
            Given A = [−1, −3], the function should return 1.
            Write an efficient algorithm for the following assumptions:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
        */

        public int Solution(int[] A)
        {
            Array.Sort(A);

            int[] distinctA = A.Distinct().ToArray();

            int max = distinctA.Max();
            if (max < 0)
            {
                return 1;
            }

            int[] finalArray = distinctA.Where(x => x > 0).ToArray();
            for (int i = 1; i < max; i++)
            {
                if (i < finalArray[i - 1])
                {
                    return i;
                }
            }

            return A[A.Length - 1] + 1;
        }
    }
}
