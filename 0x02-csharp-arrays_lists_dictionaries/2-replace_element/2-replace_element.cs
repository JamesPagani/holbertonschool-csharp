using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
        }
        else
        {
            array[index] = n;
        }

        // Regardless if a change was done or not, we still return the array.
        return array;
    }
}
