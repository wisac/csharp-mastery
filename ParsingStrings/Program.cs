using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Passing Strings");

int age = int.Parse("29");
bool isSingle = bool.Parse("true");
double weight = double.Parse("75");
decimal amount = decimal.Parse("34");

Console.WriteLine("amount = {0}, age = {1}, single = {2}, weight = {3}", amount, age, isSingle, weight);


/// PARSING DATES

DateOnly date = DateOnly.Parse("24-10-94",CultureInfo.CreateSpecificCulture("en-GH"));
Console.WriteLine(date);

TimeOnly time = TimeOnly.Parse("15:00:00");
Console.WriteLine(time);

DateTime dt = DateTime.Parse("10-21-1994");
Console.WriteLine(dt);

// USING PARSE EXACT

DateOnly birthday = DateOnly.ParseExact("2002/10/24", "yyyy/MM/dd");
Console.WriteLine("birthday: {0}",birthday);

bool valid = DateTime.TryParseExact("22-2-12 12:12:12","yy-d-MM hh:mm:ss",CultureInfo.InvariantCulture,DateTimeStyles.None,out DateTime yesterday);
Console.WriteLine($"Yesterday = {yesterday}");









