using inheritanceDemo;

Shape circle = new("circle",null);

circle.Colour = "red";

circle.DisplayInfo();


Square square = new("square", 4);
square.Colour = "green";
Console.WriteLine("perimeter: " + square.CalculatePerimeter());
square.DisplayInfo();