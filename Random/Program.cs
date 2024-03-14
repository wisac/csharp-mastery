Random random = new();

byte[] buffer = new byte[10];
random.NextBytes(buffer);

foreach (var item in buffer)
{
   Console.WriteLine(item); // random numbers
}

// generating random numbers
Console.WriteLine("Random numbers between 1 and 10");
for (var i = 0; i < 10; i++)
{
   Console.WriteLine(random.Next(1, 10));
}

// generating random string
Console.WriteLine("Generating random string");

char[] letters = new char[10];
for (var i = 0; i < 10; i++)
{
   letters[i] = Convert.ToChar('a' + random.Next(0, 26));
}
string randomStr = string.Join("", letters);
string randomStr2 = new(letters); // creating strings from chars []
Console.WriteLine(randomStr);
Console.WriteLine(randomStr2);


