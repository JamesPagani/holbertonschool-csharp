using System;

///<summary>Operations on vectors.</summary>
class VectorMath
{
    ///<summary>Calculates the Cross/Vector product of two 3D vectors.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] crossProduct;

        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[1]{-1};
        
        crossProduct = new double[3];

        crossProduct[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        crossProduct[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        crossProduct[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return crossProduct;
    }
}
