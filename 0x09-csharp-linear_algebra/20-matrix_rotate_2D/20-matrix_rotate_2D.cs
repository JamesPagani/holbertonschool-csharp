using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Rotates a square 2D matrix by an angle (in radians).</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] rotationMatrix = {{Math.Cos(angle), -Math.Sin(angle)}, {Math.Sin(angle), Math.Cos(angle)}};
        double[,] rotatedMatrix = new double[2,2]{{0, 0}, {0, 0}};

        if (matrix.GetUpperBound(0) != 1 || matrix.GetUpperBound(1) != 1)
            return new double[1, 1]{{-1}};
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    rotatedMatrix[i, j] += matrix[i, k] * rotationMatrix[k, j];
                }
            }
        }
        return rotatedMatrix;
    }
}
