namespace ArrayBasics;

class ArrayDemo
{
   public static void Demo()
   {
      // array declaration
      string[] fruits = new string[3];
      fruits[0] = "Mango";
      // fruits.ElementAt(0);
      int[] numbers = new int[3] { 1, 2, 3 }; // obj ini syntax
      int[] even = [2, 4, 6]; // simplified 


      // Arrays are reference types 
      int[] mulOfTwo = even;
      mulOfTwo[2] = 8; // also modifies even[2]

      Console.WriteLine($"even[2] = {even[2]}, mulOfTwo[2] = {mulOfTwo[2]}");
       


   }
}