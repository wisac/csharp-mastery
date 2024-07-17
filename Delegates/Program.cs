
using System.Runtime.InteropServices;
using Delegate;

// function that which delegate would be pointed to
static void toUpperCase(string text) => Console.WriteLine(text.ToUpper());
static void toLOwerCase(string text) => Console.WriteLine(text.ToLower());

// instantiate delegates and pointing them to various methods
StringDelegate delegate1 = toUpperCase;
StringDelegate delegate2 = toLOwerCase;

// calling or invoking functions pointed to by delegates
delegate1("this is lowercase");

// calling methods via delegates
delegate2.Invoke("THIS IS UPPERCASE");


// assigning a new delegate to 
StringDelegate allDelegates = toLOwerCase;

// adding another method signature to delegate
allDelegates += toUpperCase;

Console.WriteLine("Calling all delegates");


// function which accepts a delegate and therefore allow us to pass one function to another 
static void TransformString(string text, StringDelegate myDelegate)
{
   Console.WriteLine("before:" + text);
   Console.WriteLine("after:");
   myDelegate(text);
}

TransformString("Hello world", delegate1);
TransformString("WELCOME TO DELEGATES", delegate2);

allDelegates.Invoke("Hello");



static string sum(int x, int y)
{
   return (x + y).ToString();
}

// Func and Action are used to create generic delegates
Func<int, int, string> add;
add = sum;
Console.WriteLine($"Adding{add(23, 44)}");

Func<int,int> result = (i) => i + i;
Console.WriteLine(result(2));

// create a delegate that points to a function/method which takes in a string and  returns void. Delegates are declared in namespaces
namespace Delegate
{
   public delegate void StringDelegate(string text);
}





// using Func and Action

