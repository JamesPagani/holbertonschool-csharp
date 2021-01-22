using System;

///<summary>Operations on vectors.</summary>
class VectorMath
{
    ///<summary>Calculates the dot product of two vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dotProduct = 0;

        //Checking if the vectors are 2D or 3D and have the same dimensions.
        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
            return -1;

        //Performing the dot product.
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
