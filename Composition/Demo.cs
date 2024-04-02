
namespace CompoDemo;

public class Car
{
   public string Colour { get; set; }
   public string Model { get; set; }
   double _currentSpeed = 0;

   public Car()
   {
      this.EngineType = new(); // instantiating engine class
   }
   // composition
   public Engine EngineType { get; set; } // this Property must be instantiated before it's properties can be accessed
   public double Weight { get; set; }

   public void Accelerate()
   {
      if (_currentSpeed < EngineType.MaxSpeed)
      {
         _currentSpeed++;
      }
   }

   public void Decelerate(double targetSpeed)
   {
      while (_currentSpeed < targetSpeed)
      {
         _currentSpeed--;
      }
   }

   public double GetSpeed()
   {
      return _currentSpeed;
   }

}


public class Engine
{

   public double MaxSpeed { get; set; }
   public bool IsTurbo { get; set; }

}