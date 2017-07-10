using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumOddCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sumOdd = 0;
            int highestNum = 0;
            int lowestNum = 100001;
            // will iterate 1000 times.
            for (int i = 0; i <= 1000; i++)
            {   // will generate a new random number between 0 and 100000 every time the loop iterates
                int number = random.Next(0, 100001);
                // divides the number by 2 and and checks to see if it has a remaider
                // If it does it is an odd number...
                if (number % 2 != 0)
                {
                    // ...sumOdd is incremented
                    sumOdd++;
                }

                // Will check the current random number against the currently stored highest number...
                if (number > highestNum)
                {
                    //...If it is higher then highestNum becomes current random number.
                    highestNum = number;
                }

                // Will check the current random number against the currently stored lowest number...
                else if (number < lowestNum)
                {
                    //...If it is lower then lowestNum becomes the current random number.
                    lowestNum = number;
                }

            }

            // Prints the results to the screen
            Console.WriteLine("The number of odd numbers generated: " + sumOdd);
            Console.WriteLine("The Highest number generated: " + highestNum);
            Console.WriteLine("The Lowest number generated: " + lowestNum);
        }
    }
}