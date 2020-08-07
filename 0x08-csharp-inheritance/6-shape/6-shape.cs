using System;

/// <summary>
/// Base class for shapes
/// </summary>
class Shape
{
    /// <summary>
    /// Method to be overriden by children to get the area
    /// </summary>
    /// <returns>The area of the shape.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return this.width; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            
            this.width = value;
        }
    }

    public int Height
    {
        get { return this.height; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            
            this.height = value;
        }
    }
}