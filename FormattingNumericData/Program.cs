using System.Globalization;

int age = 20;

float weight = 73.5f;

double gravity = 10.0E10;

decimal amount = 100.4m;

Console.WriteLine("amount: {0}", amount.ToString("C", CultureInfo.CreateSpecificCulture("en-GH"))); // GHC20.00

Console.WriteLine("weight: {0:p}", age); // 2000.000%
Console.WriteLine("{0:N}",99999); // 99,999
Console.WriteLine("{0:D4}", 11); // 0011
Console.WriteLine("{0:X}",255); // FF




Console.WriteLine("The value 99999 in various formats:");
Console.WriteLine("c format: {0:c}", 99999);
Console.WriteLine("d9 format: {0:d9}", 99999);
Console.WriteLine("f3 format: {0:f3}", 99999);
Console.WriteLine("n format: {0:n}", 99999);
// Notice that upper- or lowercasing for hex
// determines if letters are upper- or lowercase.
Console.WriteLine("E format: {0:E}", 99999);
Console.WriteLine("e format: {0:e}", 99999);
Console.WriteLine("X format: {0:X}", 99999);
Console.WriteLine("x format: {0:x}", 99999);