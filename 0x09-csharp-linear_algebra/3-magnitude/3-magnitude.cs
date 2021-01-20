using System;

namespace _3_magnitude
{
    ///<summary>Operations with vectors.</summary>
    class VectorMath
    {
        ///<summary>Calculates the magnitude of a 2D or 3D vector.</summary>
        public static double Magnitude(double[] vector)
        {
            double a;
            double b;
            double c;
            double mag;

            //Validating if the vector is 2D or 3D.
            if (vector.Length < 2 || vector.Length > 3)
                return -1;

            //Raising each component to the power of two.
            a = vector[0] * vector[0];
            b = vector[1] * vector[1];
            c = vector.Length == 3 ? vector[2] * vector[2] : 0;

            //Finding it's square root.
            mag = Math.Sqrt(a + b + c);
            
            return Math.Round(mag, 2);
        }
    }
}