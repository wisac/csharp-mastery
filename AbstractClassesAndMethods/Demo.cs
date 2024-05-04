
abstract class Shape
{
   private string _name;
   private int? _numberOfSides;

   public Shape(string name, int? numberOfSides)
   {
      _name = name;
      _numberOfSides = numberOfSides;
   }
   public int? NumberOfSides { get { return _numberOfSides; } }
   public abstract double Perimeter();

   public abstract double Area();
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

   public override double Perimeter()
   {
      return 2 * Math.PI * _radius;
   }

   

}

class Rectangle : Shape
{
   double _length;
   double _width;

   public Rectangle(double length, double width) : base("rectangle",4)
   {
      _length = length;
      _width = width;
   }

   public double Length { get { return _length; } set { _length = value; } }
   public double Width { get{ return _width; } set{ _width = value; } }

   public override double Perimeter()
   {
      return 2 * _length + 2 * _width;
   }

   public override double Area()
   {
      return _length * _width;
   }
}