using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Multiplies two matrices.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int matrix1Rows;
        int matrix1Columns;
        int matrix2Rows;
        int matrix2Columns;
        double[,] productMatrix;

        if (matrix1 == null || matrix2 == null)
            return new double[1,1]{{-1}};

        matrix1Rows = matrix1.GetUpperBound(0);
        matrix1Columns = matrix1.GetUpperBound(1);
        matrix2Rows = matrix2.GetUpperBound(0);
        matrix2Columns = matrix2.GetUpperBound(1);

        if (matrix1Columns != matrix2Rows)
            return new double[1,1]{{-1}};

        productMatrix = new double[matrix1Rows + 1, matrix2Columns + 1];
        for (int i = 0; i < matrix1Rows + 1; i++)
        {
            for (int j = 0; j < matrix2Columns + 1; j++)
            {
                productMatrix[i, j] = 0;
                for (int k = 0; k < matrix1Columns + 1; k++)
                {
                    productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return productMatrix;
    }
}
