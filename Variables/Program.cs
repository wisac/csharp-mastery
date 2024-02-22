using System.Globalization;

int? age = null;
string? name = null;

DateTime today = DateTime.UtcNow;

// get system timezone
var zone = TimeZoneInfo.Local;

Console.WriteLine(zone);

// format time
DateTime birthday = DateTime.Parse("12-1-23", CultureInfo.InvariantCulture);
DateTime tomorrow = DateTime.ParseExact("22-02-24", "dd-M-yy",CultureInfo.InvariantCulture);

Console.WriteLine(tomorrow);


// change console background
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Press any key to start");
Console.ReadKey();
Console.WriteLine(today.ToString("\ndd MMMMM,yyyy hh:mm tt zz"));

// clear console 
Console.Clear();