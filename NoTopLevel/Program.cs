
using test;

namespace NoTopLevel
{

   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello, World!");
         Console.Write(add(4, 6));

         // Print();
         int add(int x, int y)
         {
            return x + y;
         }
      }

      void Print()
      {
         Console.WriteLine("Another method called");
         var t = new tested();
         t.Test();
      }
   }
}

namespace test 
{
   class tested {
      public void Test()
      {
         Console.WriteLine("Testing executed");
      }
   }
}
