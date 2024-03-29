namespace myApp;

public class Person
{
   DateOnly _birthDate;
   public string Name { get; set; }

// auto implemented property with a private setter. This means value can only be set in a constructor
   public string HairColour { get; private set; }

   public Person()
   {
      // default constructor. sets all fields to their default values. 
      // if a default constructor is not created, C# compiler creates one for you.
      this.Name = "User";
      this.HairColour = "black";
      this._birthDate = DateOnly.FromDateTime(DateTime.Parse("3-6-1957"));
   }

   public Person(DateOnly birthDate) : this()
   {
      this._birthDate = birthDate;
   }

   public Person(string name, DateOnly birthDate,string hairColour)
   {
      this.Name = name;
      this._birthDate = birthDate;
      this.HairColour = hairColour;
   }


   public DateOnly BirthDate
   {
      set
      {
         _birthDate = value;
      }
   }

   public int Age
   {
      get
      {
         TimeSpan difference = DateTime.Today.Date - DateTime.Parse(_birthDate.ToString());
         return difference.Days / 365;
      }

   }


   public void SetBirthDate(DateOnly birthDate)
   {
      this._birthDate = birthDate;
   }

   public void Introduce()
   {
      Console.WriteLine($"Hi, I'm {Name}, you are {Age} years old");
   }
}
