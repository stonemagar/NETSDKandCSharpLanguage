// Animal wolf = new();
// wolf.Species = "Artic Wolf";
// wolf.Weight = 45;
// wolf.Color = "white";
// wolf.Speed = 60;
// wolf.IsPackAnimal = true;

// wolf.DisplayCharacteristics();

// Top level statements
// Student bishnu = new();
// Student laxman = new();
// Student sandip = new();
// Student rajan = new();
// Student chahana = new();
// Student bikendra = new();

// bishnu.name = "Bishnu";
// bishnu.address = "Ktm";
// bishnu.roll = 23;
// bishnu.dob = new DateTime(1990, 12, 12);

// bishnu.PrintDetails();

// Create class called "Animal"
// Define at least 5 internal fields
// Define a method to print all details of animal in descriptive format
// In program entry point, create at least two objects of Animal
// Initialize fields for each instance
// Print details in concole


// using System;
// namespace inheritance;
// var rec1 = new Rectangle(5.7, 3.4);
// var p = rec1.GetPerimeter();
// var a = rec1.GetArea();
// Console.WriteLine("Rectangle:");
// Console.WriteLine($"Perimeter:{p}, Area:{a}");







// // Inheritance/Polymorphism -- OOP

// // Generics
// // LINQ
// // Async/Await
// // Attributes


// var square1=new Square(25.2);
// var sa=square1.GetArea();
// var sp=square1.GetPerimeter();
// Console.WriteLine("\nSquare:");
// Console.WriteLine($"Perimeter:{sp}, Area:{sa}");



// Circle c1 = new Circle(15.2);
// double perimeter = c1.GetPerimeter();
// double area = c1.GetArea();

// Console.WriteLine("\nCircle:");
// Console.WriteLine($"Perimeter: {perimeter}, Area:{area}" );


// Triangle triangle = new Triangle(3, 4, 5);
// Console.WriteLine("\nTriangle:");
// Console.WriteLine($"Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
    



using System;
using inheritance;

var rec1 = new Rectangle(5.7, 3.4);
var p = rec1.GetPerimeter();

var rec2 = new Rectangle(123.23, 34.3);
var a = rec2.GetArea();

var square1 = new Square(34.5);
var sa = square1.GetArea();

var circle1 = new Circle(34.5);
var ca = circle1.GetArea();

var sphere1 = new Sphere(34.5);
var ssa = sphere1.GetArea();
sphere1.PrintSphereInfo(34.5);

var triangle1 = new Triangle(3.33,5.43,3.23);
var tp = triangle1.GetPerimeter();
var ta = triangle1.GetArea();


var fileio = new FileIO();
fileio.CreateFileWithInFolder();

Console.WriteLine("sdfsadf sadfsaf asf");