namespace inheritanceDemo;

public class Square : Shape
{
   double _side;

   public Square(string name,int side) : base(name, 4)
   {
      _side = side;
   }

public double CalculateArea() {
      return _side * _side;
   }

public double CalculatePerimeter() {
      return (double)(_side * _numberOfSides);
}


}