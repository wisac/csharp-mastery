class Fields
{
   // auto implemented property
   public string Location { get; set; }
   // field
   string _name = "fields";

   // read-only field initialised.
   // A read only field can only be initialised via initialisation or in a constructor and not a method

   readonly List<int> _dimensions = [];
   private double _average = 0; // backing store for Average property
   // property

   public Fields(List<int> dimensions)
   {
      this._dimensions = dimensions;
   }

   public double Average
   {
      get
      {
         double total = 0;
         foreach (var dimension in _dimensions)
         {
            total += dimension;
         }
         _average = total / _dimensions.Count;
         return _average;
      }
   }


   public void PrintDimensions()
   {
      foreach (var dimension in this._dimensions)
      {
         Console.WriteLine(dimension);
      }
   }
}