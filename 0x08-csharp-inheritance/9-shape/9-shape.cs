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

    ///<summary>Calculates the area of the rectangle.</summary>>
    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

///<summary>Represents a basic square.</summary>
class Square : Rectangle
{
    //Square size.
    private int size;

    ///<summary>The size of the square.</summary>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
                size = value;
                Width = value;
                Height = value;
        }
    }

    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
