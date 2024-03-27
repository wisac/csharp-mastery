using System.Globalization;
using myApp;


class Order
{
   public Customer customer;
   public string Id;

   public Order()
   {
      this.customer = new();
      this.Id = new Random().Next(000, 999).ToString();
   }
   public Order(string id)
   {
      this.customer = new();
      this.Id = id;
   }
   public Order(string id, Customer customer)
   {
      this.customer = customer;
      this.Id = id;
   }

   public Order(Customer customer)
   {
      this.customer = customer;
      this.Id = new Random().Next(0, int.MaxValue).ToString();
   }

}