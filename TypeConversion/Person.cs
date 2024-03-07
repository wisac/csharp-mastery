namespace ClassDemo;

public class Person 
{

   public string? FirstName { get; set; } // getter and setter
   public string? LastName { get; set; } // getter and setter

   public void PrintInfo()
   {
      Console.WriteLine("First name is {0}, Last name is {1}",this.FirstName, this.LastName);
      
   }

}