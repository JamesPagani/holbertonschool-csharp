using System;

///<summary>A Generic queue.</summary>
class Queue<T>
{
    ///<summary>Returns the type of the queue.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
