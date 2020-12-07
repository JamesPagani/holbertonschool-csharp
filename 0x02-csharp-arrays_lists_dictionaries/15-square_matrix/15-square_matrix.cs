using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int d1, d2;
        int[,] sqrMatrix;

        d1 = myMatrix.GetUpperBound(0) + 1;
        d2 = myMatrix.GetUpperBound(1) + 1;
        sqrMatrix = new int[d1, d2];
        
        for (int i = 0; i < d1; i++)
        {
            for (int j = 0; j < d2; j++)
            {
                sqrMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return sqrMatrix;
    }
}
