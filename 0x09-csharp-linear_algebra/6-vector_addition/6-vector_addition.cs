using System;


///<summary>Operations with vectors.</summary>
class VectorMath
{
    ///<summary>Adds two 2D or 3D vectors together.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] resultVector;

        //Checking if both vectors are 2D or 3D AND if they have the same size.
        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
            return new double[] {-1};

        resultVector = new double[vector1.Length];

        //Performing the sum.
        for (int i = 0; i < resultVector.Length; i++)
            resultVector[i] = vector1[i] + vector2[i];

        return resultVector;
        }
    }
