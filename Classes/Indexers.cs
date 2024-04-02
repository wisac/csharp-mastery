public class LocalName
{
   // a dictionary with key value pairs
   readonly private Dictionary<DayOfWeek, string> _dayNamePair;

   public LocalName()
   {
      _dayNamePair = [];
      _dayNamePair.Add(DayOfWeek.Sunday, "Kwesi");
      _dayNamePair.Add(DayOfWeek.Monday, "Kojo");
      _dayNamePair.Add(DayOfWeek.Tuesday, "Kwabena");
      _dayNamePair.Add(DayOfWeek.Wednesday, "Kweku");

   }

   // an indexer to access names base on day of week
   public string this[DayOfWeek day]
   {
      get
      {
         return _dayNamePair[day];
      }
      set
      {
         _dayNamePair[day] = value;
      }
   }
}