namespace inheritanceDemo;
public class Shape
{
   string _name;
   protected int? _numberOfSides;

   public Shape(string name, int? numberOfSides)
   {
      _name = name;
      _numberOfSides = numberOfSides;
   }

   public string? Colour { get; set; }
   public void DisplayInfo(){
      Console.WriteLine($"name: {_name}, numberOfSides: {_numberOfSides}, colour: {Colour}");
      
   }

}