List<int> numbers = new List<int>();

numbers.Add(2); // append element
numbers.Insert(0, 5); // insert in the beginning

List<string> names = ["Kofi", "John"]; // initialise 

names.AddRange(["James", "Peter", "Sam"]); // adds more than one element (coll) to the list

Console.WriteLine(names.Capacity);

foreach (var name in names)
{
   Console.WriteLine(name);
}