using System;

class Program
{
    static void Main(string[] args)
    {
       for (int i = 1; i <= 100; i++)
       {
           // Determining what to put (Fizz, Buzz, FizzBuzz, or a number?)
           if (i % 3 == 0 && i % 5 == 0)
           {
               Console.Write("FizzBuzz");
           }
           else if (i % 3 == 0)
           {
               Console.Write("Fizz");
           }
           else if (i % 5 == 0)
           {
               Console.Write("Buzz");
           }
           else
           {
               Console.Write(i);
           }

           // Determining if there is another number comming or if it was the last one
           if (i == 100)
           {
               Console.WriteLine();
           }
           else
           {
               Console.Write(" ");
           }
       }
    }
}
