using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTests.Tests
{
    internal class PlaneSeatReservations
    {
        /*
            You are processing plane seat reservations. The palne has N rows of seats, numbered from 1 to N.
            There are ten seats in each row (labelled from A to K, with litter I omitted).
            
            Some os the seats are already reserved. The list of reserved seats is given as a string S (of
            lenght M) containing seat numbers separated by single spaces: for example, "1A 3C 2B 40G 5A".
            The reserved seats can be listed in S in any order.

            Your task is to allocate seats for asmany four-person families as possible. A four-person family
            occupies four seats in one row, that are next to each other - seats across an aisle (such as 2C
            and 2D) are not considered to be next to each other. It is permissible for the family to be
            separated by an aisle, but in this case exactly two people have to sit on each side of the aisle.
            Obviously, no seat can be allocated to more than one family.

            Write a function
            class Solution { public int solution(int N, string S); }
            that, given the number of rows N and a list of reserved seats as string S, returns the maximum
            number of four-person families that can be seated in the remaining unreserved seats.

            For instance, given N = 2 and S = "1A 2F 1C", your function shold return 2.
            Given N = 1 and S = "" (empty string), your function should return 2, because we can seat at 
            most two families in a single row of seats.

            Assume that:
            - N is an integer within the range [1..50]
            - M is an integer within the range [0..1,909]
            - string S consists of valid seat names separated with single spaces
            - every seat number appears in string S at most once.
        */

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
