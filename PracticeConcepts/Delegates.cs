namespace Practice;

public delegate int ageDelegate(DateTime dob);

public class Person
{
   string name;
   DateTime _dateOfBirth;


   public DateTime DateOfBirth
   {
      set
      {
         this._dateOfBirth = value;
      }
      get
      {
         return this._dateOfBirth;
      }

   }


   public static int CalcAge(DateTime dob)
   {
      TimeSpan diff = DateTime.UtcNow - dob;
      int age = diff.Days / 365;
      return age;
   }
}