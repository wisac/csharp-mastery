namespace Demo;

class Fruit
{
   string name;

   public Fruit(string name)
   {
      this.name = name;
   }
   public string Type { get; set; }

}


class Mango : Fruit
{
   public int Total { get; set; }

   // This parameterless constructor cannot be created because it has no corresponding base constructor. In other to create this parameterless constructor, we need to tell the compiler how to initialise the base class when this constructor is called.

   // public Mango()
   // {
   //    Total = 5;
   // }


   // We telling the compiler how to initialise the base class by calling a base constructor to initialise the base class when this constructor is called
   public Mango() : base("mango") {
      // initialise derived class fields here
   }


}