using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == i)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
