using System;

///<summary>Operations with matrices.</summary>
class MatrixMath
{
    ///<summary>Shears a square 2D matrix by a given factor (and axis).</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double x, y;
        double[,] shearMatrix;
        double[,] skewedMatrix = new double[2,2]{{0,0},{0,0}};

        if (matrix.GetUpperBound(0) != 1 || matrix.GetUpperBound(1) != 1)
            return new double[1,1]{{-1}};
        if (direction != 'x' && direction != 'y')
            return new double[1,1]{{-1}};

        x = direction == 'x' ? factor : 0;
        y = direction == 'y' ? factor : 0;
        shearMatrix = new double[2,2]{{1,x},{y,1}};

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    skewedMatrix[i, j] += matrix[i, k] * shearMatrix[k, j];
                }
            }
        }
        return skewedMatrix;
    }
}
