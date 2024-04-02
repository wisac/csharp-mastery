using System.Globalization;

class Shape
{
   private string _name;
   private int? _numberOfSides;

   public Shape(string name, int? numberOfSides)
   {
      _name = name;
      _numberOfSides = numberOfSides;
   }


   public virtual double Area()
   {
      return 0;
   }
}


class Circle : Shape
{
   private double _radius;
   public Circle(double radius) : base("circle", null)
   {
      _radius = radius;
   }
   public double Radius { get { return _radius; } set { _radius = value; } }

   public override double Area()
   {
      return Math.PI * Math.Pow(Radius, 2);
   }

}