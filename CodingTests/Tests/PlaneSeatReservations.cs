using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests.Tests
{
    internal class PlaneSeatReservations
    {
        /**/

        private int CheckOccupiedSeats(int total, string seat, int row)
        {
            char seatLetter = seat.Length < 3 ? seat[1] : seat[2];

            if (seatLetter == 'B' || seatLetter == 'C' || seatLetter == 'D' || seatLetter == 'E')
            {
                total--;
            }
            if (seatLetter == 'F' || seatLetter == 'G' || seatLetter == 'H' || seatLetter == 'J')
            {
                total--;
            }

            return total;
        }

        public int Solution(int N, string S)
        {
            int totalFamilies = N * 2;

            if (S == "")
            {
                return totalFamilies;
            }

            string[] reservedSeats = S.Split(" ");

            for (int i = 1; i <= N; i++)
            {
                foreach (string seat in reservedSeats)
                {
                    if ((seat.Length < 3 && seat[0].ToString() == i.ToString()) || (i >= 10 & seat.Contains(i.ToString())))
                    {
                        totalFamilies = CheckOccupiedSeats(totalFamilies, seat, i);
                    }
                }
            }

            return totalFamilies;
        }
    }
}
