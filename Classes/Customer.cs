namespace myApp;

class Customer
{
   public string? Id;
   public string? Name;
   public List<Order> orders; // this collection is not initialized yet and would throw an exception if called without it being init

   public Customer()
   {
      this.orders = []; // collection initialized to empty list
      this.Name = null;
      this.Id = null;
   }
   // constructors using constructor delegation to init list
   public Customer(string name) : this()
   {
      this.Id = new Random().Next(000, int.MaxValue).ToString();
      this.Name = name;
   }

   public Customer(string id, string name) : this(name)
   {
      this.Id = id;
   }


   public void DisplayInfo(){
      Console.WriteLine($"----- Customer details -----");
      Console.WriteLine($"Name: {this.Name}");
      Console.WriteLine($"Id: {this.Id}");
      foreach (var order in orders)
      {
         Console.WriteLine($"---- Order details ---");
         Console.WriteLine($"Ordered by: {order.customer.Name}, order Id: {order.Id}");
      }
      
   }

}