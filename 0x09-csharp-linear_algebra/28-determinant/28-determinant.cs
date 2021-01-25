using System;

///<summary>Operations on matrices.</summary>
class MatrixMath
{
    ///<summary>Finds the determinant of the matrix.</summary>
    public static double Determinant(double[,] matrix)
    {
        //Determinant and elements of the matrix.
        double det;
        double a, b, c, d, e, f, g, h, i;
        int matrixRows, matrixCols;

        //Checking if the matrix is null.
        if (matrix == null)
            return -1;

        //Checking if the matrix is 2D or 3D AND if it is square.
        matrixRows = matrix.GetUpperBound(0) + 1;
        matrixCols = matrix.GetUpperBound(1) + 1;
        if ((matrixRows < 2 || matrixRows > 3) || (matrixCols < 2 || matrixCols > 3) || (matrixRows != matrixCols))
            return -1;
        
        det = 0;

        /*
            3D Matrix
            [a,b,c]
            [d,e,f]
            [g,h,i]

            2D Matrix
            [a,b]
            [c,d]
        */

        a = matrix[0,0];
        b = matrix[0,1];
        c = matrixRows == 3 ? matrix[0,2] : matrix[1,0];
        d = matrixRows == 3 ? matrix[1,0] : matrix[1,1]; //If the matrix is 2D, this would be all the elements.
        e = matrixRows == 3 ? matrix[1,1] : 0;
        f = matrixRows == 3 ? matrix[1,2] : 0;
        g = matrixRows == 3 ? matrix[2,0] : 0;
        h = matrixRows == 3 ? matrix[2,1] : 0;
        i = matrixRows == 3 ? matrix[2,2] : 0;

        if (matrixRows == 2)
        {
            det = (a*d) - (b*c);
        }
        else
        {
            det = (a*e*i) + (b*f*g) + (c*d*h) - (a*f*h) - (b*d*i) - (c*e*g);
        }
        
        return det;
    }
}
