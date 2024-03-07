namespace Shape;
public struct Circle(double radius)
{
   public double Radius { set; get; } = radius;

   public double CalcArea()
   {
      return Math.PI * Math.Pow(Radius, 2);
   }

   public static double CalcArea(double radius)
   {
      return Math.PI * Math.Pow(radius, 2);
   }

   public double CalcCircumference()
   {
      return Math.PI * 2 * Radius;
   }

   public static double CalcRadius(double area)
   {
      return Math.Sqrt(area / Math.PI);
   }

}


public struct Rectangle
{
   public double Length { set; get; }
   public double Width { set; get; }

   public readonly double CalcArea()
   {
      return Length * Width;
   }

   public static double CalcArea(double length, double Width)
   {
      return length * Width;
   }

}