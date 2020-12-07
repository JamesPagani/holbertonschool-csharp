using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the new Jagged Array
            int[][] jaggedArray = new int[3][];

            // Initializing the arrays inside the jagged array
            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[7];
            jaggedArray[2] = new int[2];

            // Filling the arrays.
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = j;
                }
            }

            // Printing the arrays
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (j > 0)
                        Console.Write(" ");
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
