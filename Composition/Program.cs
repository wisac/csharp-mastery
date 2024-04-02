using CompoDemo;

Car myCar = new()
{
   Colour = "black",
   Model = "Benz",
   EngineType = new() // instantiating the engine class
};

myCar.EngineType.IsTurbo = true;
myCar.EngineType.MaxSpeed = 250;
myCar.Accelerate();

Console.WriteLine(myCar.GetSpeed());

