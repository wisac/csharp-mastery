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

