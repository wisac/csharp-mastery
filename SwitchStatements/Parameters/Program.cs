using System.Globalization;

Console.Write("Enter Date of Birth in the format DD/MM/YY and press Enter: ");
string? inputDateOfBirth = Console.ReadLine();
Console.Write("What is your gender? Male = 1, Female = 2: ");
string? inputGender = Console.ReadLine();

bool validDOB = DateOnly.TryParseExact(inputDateOfBirth, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly dateOfBirth);
if (!validDOB)
{
   Console.WriteLine($"Invalid Date of birth. Date of birth must be in the format DD/MM/YY {dateOfBirth}");
   return;
}

bool validGender = Enum.TryParse(inputGender, true, out Gender gender);
if (!validGender || !Enum.IsDefined(typeof(Gender), gender))
{
   Console.WriteLine("Gender is invalid. Gender can only be 1 (male) or 2 (female)");
   return;
}

// calculate age and local name from DOB and gender
int? age;
Person.CalcAge(dateOfBirth, out age);
string localName = Person.LocalName(ref dateOfBirth, gender);
Console.WriteLine($"Hello {localName}, your age is {age}");

class Person
{
    // age calculator
   public static void CalcAge(DateOnly dateOfBirth, out int? age)
   {
      DateOnly today = DateOnly.FromDateTime(DateTime.UtcNow);
      age = today.Year - dateOfBirth.Year;
      if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
      {
         age--;
      }
   }

   // find local name from DOB and gender
   public static string LocalName(ref DateOnly dateOfBirth, Gender gender)
   {
      DayOfWeek dayOfWeekBorn = dateOfBirth.DayOfWeek;
      // switch expressions and ternary expression
      string localName = gender == Gender.Male
      ? dayOfWeekBorn switch
      {
         DayOfWeek.Monday => "Kojo",
         DayOfWeek.Tuesday => "Kwabena",
         DayOfWeek.Wednesday => "Kwaku",
         DayOfWeek.Thursday => "Yaw",
         DayOfWeek.Friday => "Kofi",
         DayOfWeek.Saturday => "Kwame",
         _ => "Kwesi",
      }
      : dayOfWeekBorn switch
      {
         DayOfWeek.Monday => "Adwoa",
         DayOfWeek.Tuesday => "Abena",
         DayOfWeek.Wednesday => "Akua",
         DayOfWeek.Thursday => "Yaa",
         DayOfWeek.Friday => "Efua",
         DayOfWeek.Saturday => "Ama",
         _ => "Akosua",
      };
      return localName;
   }
}

public enum Gender
{
   Male = 1,
   Female = 2
}
