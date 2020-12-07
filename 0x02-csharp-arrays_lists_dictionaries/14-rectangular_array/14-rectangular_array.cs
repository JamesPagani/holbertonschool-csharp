using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the 2D Array
            int[,] doubleArray = new int[5, 5];
            int i, j;

            // Initializing the 2D Array
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    doubleArray[i, j] = (i == 2 && j == 2) ? 1 : 0;
                }
            }

            // Printing the 2D Array
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j > 0)
                        Console.Write(" ");
                    Console.Write(doubleArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
