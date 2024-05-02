using System;
using Inheritance;
namespace inheritance;
class Circle : IShape2D
{
    public Circle(double r)
    {
        radius=r;
    }
    protected double radius;
     public virtual double GetArea()=> Math.PI * radius * radius;
    public virtual double GetPerimeter()=>2 * Math.PI * radius;
}