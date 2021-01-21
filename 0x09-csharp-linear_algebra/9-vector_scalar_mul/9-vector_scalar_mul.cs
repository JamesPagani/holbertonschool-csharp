using System;

///<summary>Operations on vectors.</summary>
class VectorMath
{
    ///<summary>Multiplies a 2D or 3D vector with a scalar.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] scaledVector;

            //Checking if the vector is 2D or 3D
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
            
            //Performing the scaling
        scaledVector = new double[vector.Length];
        for(int i = 0; i < scaledVector.Length; i++)
            scaledVector[i] = vector[i] * scalar;

        return scaledVector;
    }
}
