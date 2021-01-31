using System;

///<summary>An object.</summary>
class Obj
{
    ///<summary>Detects if <paramref name="derivedType"/> inherits from, but is not an instance of, <paramref name="baseType"/>.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
