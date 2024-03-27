namespace myApp;

public class Person
{

   public Person(){
      // default constructor. sets all fields to their default values. 
      // if a default constructor is not created, C# compiler creates one for you.
      this.name = string.Empty;
   }
   public Person(string name, int age)
   {
      this.name = name;
      this.Age = age;
   }
   public string name { get; set; }
   public int Age
   {
      get
   ;
      set;
   }

   public void Introduce()
   {
      Console.WriteLine($"Hi, I'm {name}, you are {Age} years old");
   }
   public static void Introduce(string name, int age)
   {
      Console.WriteLine($"Hi, I'm {name}, you are {age} years old");
   }
}
