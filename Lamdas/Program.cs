


List<int> ages = [1, 2, 4, 5, 75, 34, 43, 12, 33, 31];

// find even numbers
List<int> evenNumbers = ages.FindAll(age => age % 2 == 0);

foreach (var number in evenNumbers)
{
   Console.WriteLine(number);
}

Console.WriteLine($"mul3 {test.Ans}");


int res = ages.RemoveAll(i =>
{
   return i > 5;
}
);


class test
{
   static int getMul3(List<int> ints)
   {
      return ints.Find(a => a % 3 == 0);
   }


   public static int Ans => test.getMul3([5, 67, 34, 23, 12, 32, 54, 66]);
   

}


