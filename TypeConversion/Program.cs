
using System.Runtime.InteropServices;
using ClassDemo;

byte age = 5;
int b = age; // implicit conversion

float f = 5f;
int c = (int)f; // explicit casting

decimal m = Convert.ToDecimal(f); // using convert class

Person person = new();

person.FirstName = "Isaac"; // setting properties
person.LastName = "Wilson";

Console.WriteLine(person.FirstName); // getting properties

person.PrintInfo();


