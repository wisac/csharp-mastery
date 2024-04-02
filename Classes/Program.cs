using System.Security.Cryptography;
using myApp;

// Person person = new();

// // person.Age = 24;
// person.name = "Kojo";

// person.Introduce();

Customer customer = new()
{
   Name = "Kojo",
   Id = "123",
};

customer.orders.Add(new Order(new Random().Next(0, int.MaxValue).ToString(), customer));
Order order = new(customer);
customer.orders.Add(order);
customer.DisplayInfo();


Fields myField = new([1,2,3,5,4,5,6]);

Console.WriteLine("Fields");
// Fields emptyField = new();  // not possible since a default constructor was not implemented;


myField.PrintDimensions();
Console.WriteLine(myField.Average );


Person kofi = new();
kofi.Introduce();

Person john = new("John Smith", new DateOnly(1994, 10, 10),"blond");

john.Introduce();

Person rose = new()
{
   Name = "Rose",
   BirthDate = new DateOnly(2000, 10, 21)
};
// rose.HairColour = "red"; // inaccessible

rose.Introduce();


Console.WriteLine("\nINDEXERS");

LocalName localName = new();

Console.WriteLine("Monday = {0}",localName[DayOfWeek.Monday]);
localName[DayOfWeek.Thursday] = "Yaw";

Console.WriteLine("Thursday = {0}",localName[DayOfWeek.Thursday]);



