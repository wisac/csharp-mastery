using System.Text;
/* 
   String builder creates a mutable string with various methods for manipulating the string. 
*/


StringBuilder phoneNumber = new(); // declare and set initial size

// append method
phoneNumber.Append('0');
phoneNumber.Append("244");

Console.WriteLine(phoneNumber.Length); // 3
Console.WriteLine(phoneNumber.Capacity); // The current capacity of the string ranges from default to MaxCapacity

Console.WriteLine(phoneNumber.MaxCapacity); // memory dependent

string countryCode = "+233";
phoneNumber.Remove(0, 1).Insert(0, countryCode);

phoneNumber.Append(new Random().Next(0000000,99999999));

Console.WriteLine("phone number {0}",phoneNumber);






