using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] arr;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;

                // Print the recently added number. If there are more elemnts to add, separate them with a space.
                Console.Write(arr[i]);
                if (i < size - 1)
                    Console.Write(" ");

            }
        }
        Console.WriteLine();
        return arr;
    }
}
