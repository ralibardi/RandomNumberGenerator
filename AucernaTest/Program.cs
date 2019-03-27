using System;

namespace AucernaTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            getRandom(1000); // The array to return

            Console.ReadLine();
        }

        private static int[] getRandom(int size)
        {
            int nextNumber; // Variable that will hold the random number
            var randomArray = new int[size]; // The array to return
            var booleanInArray = new bool[size]; // Array of numbers that have been used
            var random = new Random(); // The initializer of the random instance
            var counter = 0; // This variable has how many numbers have been saved

            while (counter < size) // Terminate the loop when the array have been filled
            {
                nextNumber = random.Next(1, size + 1); // Get the next random number

                if (booleanInArray[nextNumber - 1]) // Check if the number have been used
                    continue;

                randomArray[counter] = nextNumber; // Save the random number in the array
                booleanInArray[nextNumber - 1] = true; // This number was used
                Console.WriteLine(randomArray[counter]); // Print the number
                counter++;
            }

            return randomArray;
        }
    }
}
