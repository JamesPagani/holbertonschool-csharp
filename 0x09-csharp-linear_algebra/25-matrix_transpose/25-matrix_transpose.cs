using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Transposes a matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int matrixRows;
        int matrixCols;
        double[,] transMatrix;

        if (matrix == null || matrix.Length == 0)
            return new double[0,0];

        matrixRows = matrix.GetUpperBound(0) + 1;
        matrixCols = matrix.GetUpperBound(1) + 1;

        transMatrix = new double[matrixCols, matrixRows];
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                transMatrix[j, i] = matrix[i, j];
            }
        }

        return transMatrix;
    }
}
