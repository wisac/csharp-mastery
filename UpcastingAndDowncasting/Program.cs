using System.Collections.Concurrent;

Car myCar = new()
{
   Name = "SomeCar",
   Model = "some Model"
};


// Create new Car from a Toyota class
Car myToyota = new Toyota()
{
   Manufacturer = "Toyota",
   Name = "X4"
};

// myToyota.ShowToyota();  // ShowToyota not available on Car. In order to have ShowCar method available on myToyota which is a Car object, we need to down cast it to Toyota object


// down casting 
Toyota castedCar = (Toyota)myToyota;

castedCar.ShowToyota();
castedCar.ShowCar();


Toyota newToyota = new();

// up casting 
Car newCar = newToyota;

newCar.Model = "BMW";
newCar.ShowCar();


if (newCar is Car)
{
   Console.WriteLine("New Car is of type Car");
}
else
{
   Console.WriteLine("New Car is not type Car");

}

Toyota anotherToyota = myCar as Toyota;

if (anotherToyota != null)
{
   Console.WriteLine("Another toyota is now a Toyota and the downcast worked");

}
else
{
   Console.WriteLine("Downcast of newCar to Another toyota failed");
}







