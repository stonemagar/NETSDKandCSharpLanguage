using System;
namespace inheritance;
class Sphere : Circle
{
   

    public Sphere(double radius) : base(radius)
    {}
    public override double GetArea() => 4 * Math.PI * radius * radius;
      public void PrintSphereInfo()
    {

    }

    public void PrintSphereInfo(double radius)
    {
        
    } 
}