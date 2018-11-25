using System;

namespace Csharp_Euler001
{
    class Program
    {
        static void Main(string[] args)
        {   /*  Euler Challenge #1
                Find the sum of all multiples of 3 or 5, which are less than 1,000.   
                https://projecteuler.net/problem=1  */

            int sumTotal = 0;
            for (int x=1; x<1000; x++)
            {
                bool multipleOf = false;
                multipleOf = IsMultOf(3, x);
                if (!multipleOf){
                    multipleOf = IsMultOf(5, x);
                }
                if (multipleOf){
                    sumTotal += x;
                }
            }
            Console.WriteLine("Euler Challenge #1\n\nThe sum of all multiples of 3 or 5, that are less than 1,000 = {0}.", sumTotal);
            Console.ReadLine();
        }

        static bool IsMultOf(int thisNumber, int checkThis)
        {   // determines if the second number is a multiple of the first number.
            // returns true if a multiple.  false if not a multiple.
            if(checkThis % thisNumber == 0){
                return (true);
            }
            else{
                return (false);
            }

        }
    }
}
