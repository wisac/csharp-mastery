using System.Globalization;

DateOnly DOB = DateOnly.ParseExact("10/10/94", "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None);

int? age = null;
Person.CalcAge(DOB, out age);
Console.WriteLine($"Your age is {age}");

class Person
{
   public static void CalcAge(DateOnly dateOfBirth, out int? age)
   {
      DateOnly today = DateOnly.FromDateTime(DateTime.UtcNow);

      age = today.Year - dateOfBirth.Year;

      if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
      {
         age--;
      }
   }
}

