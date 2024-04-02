class Car {
   public string Model { get; set; }
   public string Name { get; set; }
   public void ShowCar(){
      Console.WriteLine("Model:" + Model + " Name:" + Name);
      
   }



}


class Toyota : Car {
   public string Manufacturer { get; set; }
   public void ShowToyota()
   {
      Console.WriteLine($"Model: {Model}, Name : {Name}, Manufacturer: {Manufacturer}");

   } 
}