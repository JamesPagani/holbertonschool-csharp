﻿using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (i == 8 && j == 9)
                    {
                        Console.Write("{0}{1}\n", i, j);
                    }
                    else
                    {
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
        }
    }
}
