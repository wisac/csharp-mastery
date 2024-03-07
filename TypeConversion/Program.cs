using ClassDemo;
using Shape;

Console.WriteLine("Type Casting");

byte age = 5;
int b = age; // implicit conversion

float f = 5f;
int c = (int)f; // explicit casting

decimal m = Convert.ToDecimal(f); // using convert class


Console.WriteLine("Working with objects");

// simplified object instantiation
Person person = new()
{
   FirstName = "Isaac", // setting properties
   LastName = "Wilson"
};

Console.WriteLine(person.FirstName); // getting properties

person.PrintInfo();


Circle circle = new();
circle.Radius = 7;

Console.WriteLine("Working with struct");
Console.WriteLine("Area of circle 1 = {0:f2}", circle.CalcArea());
Console.WriteLine("Area of circle with radius 14 = {0:f2}",Circle.CalcArea(14));



