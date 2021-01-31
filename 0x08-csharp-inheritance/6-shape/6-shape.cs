using System;

///<summary>Represents any basic shape.</summary>
class Shape
{
    ///<summary>Calculates the area of a shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Represents a rectangle.</summary>
class Rectangle : Shape
{
    //Width of the rectangle.
    private int width;
    //Height of the rectangle.
    private int height;

    ///<summary>The width of the rectangle.</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    ///<summary>The height of the rectangle.</summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}
