using System.Globalization;
using System.Security.Authentication;

Console.Write("Enter name and press enter: ");
string? name = Console.ReadLine();

Console.Write("Enter your date of birth in format DD/MM/YY and press enter: ");
string? dateOfBirthInput = Console.ReadLine();

Console.WriteLine("Press any key to reveal your age!");
Console.ReadKey();

bool validDateOfBirth = DateTime.TryParseExact(dateOfBirthInput, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out DateTime dateOfBirth);

if (validDateOfBirth)
{
   DateTime today = DateTime.Today;

   int age = today.Year - dateOfBirth.Year;

   if ((today.Month < dateOfBirth.Month)
      || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
   {
      age--;
   }
   Console.ForegroundColor = ConsoleColor.DarkGreen;
   Console.WriteLine($"Hello {name}, you are {age} years old!");
}
else
{
   Console.ForegroundColor = ConsoleColor.DarkRed;
   Console.WriteLine("Invalid Date of birth. Date of birth should be in the form DD/MM/YY");
}



// TimeSpan difference = today - dateOfBirth;
// Console.WriteLine(today - dateOfBirth);

// age = (int)(difference.TotalDays / 365.65);
// Console.WriteLine(difference.TotalDays); 
// DateTime today = DateTime.Parse("10-10-24 00:00");
// Console.Beep();
