// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch statements");
char myChar = '\u0061'; // a
string firstName = "Isaac";

switch (myChar)
{
   case 'b':
      Console.WriteLine("case b");
      break;
   case 'a':
      if (firstName.Contains(myChar))
      {
         goto case 'c';
      }
      break;
   case 'c':
      Console.WriteLine($"case c: {firstName} contains {myChar}");
      break;

   default:
      Console.WriteLine("default");
      break;

}
