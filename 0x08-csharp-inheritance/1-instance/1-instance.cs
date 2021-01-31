using System;

///<summary>An object.</summary>
class Obj
{
    ///<summary>Detects if the object is an instance or is a derivate from the Array class.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
