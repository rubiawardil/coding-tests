using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests.Tests
{
    internal class CastlesInHillsAndValleys
    {
        public int Solution(int[] A)
        {
            int[] distinctA = A.Distinct().ToArray();
            if (distinctA.Length == 1)
            {
                return 1;
            }

            int castles = 0;
            bool up = false, down = false;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i + 1] > A[i])
                {
                    if (down == true)
                    {
                        castles++;
                    }
                    up = true;
                    down = false;
                }
                else if (A[i + 1] < A[i])
                {
                    if (up == true)
                    {
                        castles++;
                    }
                    down = true;
                    up = false;
                }
            }
            castles += 2; // add castles to first and last segments
            return castles;
        }
    }
}
