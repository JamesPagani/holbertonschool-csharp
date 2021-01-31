using System;

///<summary>An object.</summary>
class Obj
{
    ///<summary>Detects if the given object is an int.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
