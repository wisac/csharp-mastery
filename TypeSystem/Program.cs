// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("=> System.Object Functionality:");
// A C# int is really a shorthand for System.Int32,
// which inherits the following members from System.Object.
Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
Console.WriteLine("12.ToString() = {0}", 12.ToString());
Console.WriteLine("12.GetType() = {0}", 12.GetType());
Console.WriteLine();

Console.WriteLine(12.GetType());
Console.WriteLine(12.GetHashCode());
Console.WriteLine("we".GetType());

string firstName = "Isaac";
string lastName = firstName;

lastName = "Wilson";
Console.WriteLine(firstName);
Console.WriteLine(lastName);




// members of numeric data types

Console.WriteLine(int.DivRem(23,2));
Console.WriteLine(decimal.Round(3.55m,1));
Console.WriteLine(double.Abs(-343.42343));
Console.WriteLine(double.Pow(3,2));

Console.WriteLine(bool.FalseString);

char a = '\u0061'; // a
char smileEmoji = '\u263A';
char one = '\u0030';
char five = '5';
Console.WriteLine(one);

Console.WriteLine("=> char type Functionality:");
char myChar = 'a';
Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
char.IsWhiteSpace("Hello There", 5));



// Console.WriteLine('\ub000');










