using ArrayBasics;

ArrayDemo.Demo();

ArrayDemo.MultiDimArr();
ArrayDemo.MultiDimArr2();

ArrayDemo.JaggedArr1();

int[] numbers = [2, 3, 4,45,2,6,9];

Array.BinarySearch(numbers, 2); // binary search
// Array.Clear(numbers); // clears the array
Array.Resize(ref numbers, 10);
Console.WriteLine(numbers.Length); // resizes an array by muting the size.
Array.Sort(numbers); // sorts the array (mutable)
foreach(var item in numbers){
   Console.WriteLine(item);
   
}

int[] n = new int[6];


Array.Copy(numbers, n, 5); // copies an elements to new array

foreach (var item in n)
{
   Console.WriteLine(item);
}


Array.Reverse(n); // reverses the array