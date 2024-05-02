using System;
namespace inheritance;
class Triangle : Rectangle
{
    private double side1;
    private double side2;
    private double side3;

       public Triangle(double side1, double side2, double side3) : base(side1, side2) // Assuming base class requires two arguments
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

 public  double GetArea()
    {
        // Using Heron's formula for area
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public  double GetPerimeter()
    {
        return side1 + side2 + side3;
    }
}