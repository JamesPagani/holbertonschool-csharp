using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Adds two vectors together.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixSum;
        int matrix1Rows;
        int matrix1Columns;
        int matrix2Rows;
        int matrix2Columns;

        //Checking if any of the matrices is NULL.
        if (matrix1 == null || matrix2 == null)
            return new double[1,1]{{-1}};

        //Checking if the matrices are 2D or 3D and if they have the same size.
        matrix1Rows = matrix1.GetUpperBound(0);
        matrix1Columns = matrix1.GetUpperBound(1);
        matrix2Rows = matrix2.GetUpperBound(0);
        matrix2Columns = matrix2.GetUpperBound(1);

        if ((matrix1Rows < 1 || matrix1Rows > 2) || (matrix2Rows < 1 || matrix2Rows > 2) || (matrix1Rows != matrix2Rows || matrix1Columns != matrix2Columns))
            return new double[1,1]{{-1}};

        matrixSum = new double[matrix1Rows + 1, matrix1Columns + 1];

        for(int i = 0; i <= matrix1Rows; i++)
        {
            for (int j = 0; j <= matrix1Columns; j++)
            {
                matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return matrixSum;
    }
}
