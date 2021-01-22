using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Multiplies a matrix with a scalar number.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] scaledMatrix;
        int matrixRows;
        int matrixCols;

        //Checking if the matrix is valid.
        if (matrix == null)
            return new double[1,1]{{-1}};

        matrixRows = matrix.GetUpperBound(0) + 1;
        matrixCols = matrix.GetUpperBound(1) + 1;

        if (matrixRows < 2 || matrixRows > 3)
            return new double[1,1]{{-1}};

        scaledMatrix = new double[matrixRows, matrixCols];

        //The scalar multiplication itself.
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                scaledMatrix[i, j] = scalar * matrix[i, j];
            }
        }

        return scaledMatrix;
    }
}
