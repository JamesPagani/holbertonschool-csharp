using System;

namespace MyMath
{
    ///<summary>Represents a Two Dimensional Array</summary>
    public class Matrix
    {
        ///<summary>Divides all the elements in a matrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            int[,] outputMatrix = new int[matrix.GetUpperBound(0) + 1, matrix.GetUpperBound(1) + 1];

            try
            {
                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    {
                        outputMatrix[i,j] = matrix[i,j] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            return outputMatrix;
        }
    }
}
