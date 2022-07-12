using System.Collections.Generic;
using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else if  (i % 2 == 1) 
                {
                    oddList.Add(i);
                }

                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */
                Console.WriteLine("These are all the evens");
                foreach (int number in evenList)
                {
                    Console.WriteLine($"{number} is an even number");
                }

                Console.WriteLine("All the odds");
                foreach (int number in oddList)
                {
                    Console.WriteLine($"{number} is an odd number");
                }
            }
        }
    }
}
