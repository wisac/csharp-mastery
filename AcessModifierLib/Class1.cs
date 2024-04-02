namespace AcessModifierLib;

// not accessible outside assembly or project
internal class InternalClass
{
   protected string some;

   public static void OutputSomething(){
      Console.WriteLine("In internal class lib");
      
   }
}

// accessible outside assembly or project
public class NotInternalClass {
   public static void OutputSomething(){
      Console.WriteLine("Not internal class classed");

      
   }
}


// accessible outside assembly or project
public class Something {
   public void PrintSomething(){
      Console.WriteLine("Something");
      
   }
}
