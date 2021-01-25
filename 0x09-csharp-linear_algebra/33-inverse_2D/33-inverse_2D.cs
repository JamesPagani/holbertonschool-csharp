using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Calculates the inverse of a 2D matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] inverseMatrix;
        double det;

        if (matrix.GetUpperBound(0) != 1 || matrix.GetUpperBound(1) != 1)
            return new double[1,1]{{-1}};

        inverseMatrix = new double[2,2] {{matrix[1,1], -matrix[0,1]}, {-matrix[1,0], matrix[0,0]}};
        det = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];

        for (int i = 0; i < inverseMatrix.GetUpperBound(0)+1; i++)
        {
            for (int j = 0; j < inverseMatrix.GetUpperBound(1)+1; j++)
            {
                inverseMatrix[i,j] *= Math.Round(1 / det, 2);
            }
        }

        return inverseMatrix;
    }
}
