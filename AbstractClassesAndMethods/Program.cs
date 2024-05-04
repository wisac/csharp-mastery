//  Shape shape = new(); // not possible. Abstract class cannot be instantiated
Circle circle = new(7);

Console.WriteLine("Perimeter of Circle: " + circle.Perimeter());
Console.WriteLine("Area of circle: " + circle.Area());

Rectangle rectangle = new(5,4);
Console.WriteLine("Perimeter of Rectangle: " + rectangle.Perimeter());
Console.WriteLine("Area of Rectangle: " + rectangle.Area());



