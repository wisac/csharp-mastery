using System.Globalization;

namespace Averages;

public static class AverageCalculator
{
   public static double ArithmeticMean(string[] args)
   {
      double total = 0;
      foreach (string input in args)
      {
         total += double.Parse(input);
      }

      Console.Write("IN HERE");
      return total / args.Length;
   }
}