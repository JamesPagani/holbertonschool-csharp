using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>An object.</summary>
class Obj
{
    ///<summary>Prints the name of all available properties and methods of <paramref name="myObj"/>.</summary>
    public static void Print(object myObj)
    {
        TypeInfo objTypeInfo = myObj.GetType().GetTypeInfo();
        List<PropertyInfo> objProperties = new List<PropertyInfo>(objTypeInfo.GetProperties());
        List<MethodInfo> objMethods = new List<MethodInfo>(objTypeInfo.GetMethods());

        Console.WriteLine("{0} Properties:", objTypeInfo.Name);
        foreach(PropertyInfo property in objProperties)
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine("{0} Methods:", objTypeInfo.Name);
        foreach(MethodInfo method in objMethods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
