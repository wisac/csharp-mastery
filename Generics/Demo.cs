using System.Globalization;

namespace Demo;

class DataStore<T>
{
   public T Data { get; set; }
}

class Items<T>
{
   private readonly List<T> _items = [];
   public void Add(T item)
   {
      if (!_items.Contains(item))
         _items.Add(item);
      else
         throw new Exception($"Item {item} already exist");
   }

   public void ListItems()
   {
      foreach (var item in _items)
      {
         Console.Write(item + ",");
      }
   }

   public T Max<T>(T a, T b) where T : IComparable
   {
      return a.CompareTo(b) > 0 ? a : b;
   }

}


class Gene {
   public static bool Converting<T>(T a) where T : IConvertible {
      bool answer = a.ToBoolean(CultureInfo.InvariantCulture);
      Console.WriteLine(answer);
      
      return answer;
   }
}