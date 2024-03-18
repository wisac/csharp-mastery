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

   // 2 dimensional array
   public static void MultiDimArr()
   {
      int[,] factors = new int[2, 3] { { 2, 4, 6 }, { 1, 2, 3 } };

      for (int i = 0; i < factors.GetLength(0); i++)
      {
         for (int j = 0; j < factors.GetLength(1); j++)
         {
            Console.WriteLine("factors: [{0}] [{1}] = {2}", i, j, factors[i, j]);
         }
      }
   }

   // 3 dimensional array
   public static void MultiDimArr2()
   {
      int[,,] arr = new int[2, 2, 2]
      {
         {{1,2},{3,4}},
         {{5,6},{7,8}}

      };
      for (int i = 0; i < arr.GetLength(0); i++)
      {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
               Console.WriteLine("arr: [{0}][{1}][{2}] = {3}", i, j, k, arr[i, j, k]);
            }
         }
      }
   }


   public static void JaggedArr1()
   {
      int[][] numbers = [[2, 3], [4, 5, 3]];

      numbers.GetLength(0);
      Console.WriteLine(Array.IndexOf(numbers[1], 5));


   }
   

}