// concat strings
string hello = string.Format("hello {0}", "world");

int[] code = [2, 3, 3];
string countryCode = string.Join("", code);

// text will appear exactly as writing with next lines
Console.WriteLine(@"9080384\l'm\
jljldjljlfj
ljljdljflsj
jllsjk ldfjlkj\n");



Console.WriteLine(countryCode);
Console.WriteLine(hello);


// string methods
string fullName = "isaac wilson";

Console.WriteLine(fullName.ToUpper());

 // split method
string firstName = fullName.Split(' ')[0];
Console.WriteLine("first name: {0}",firstName);

// substring method
// string lastName = fullName.Substring(fullName.IndexOf(' '));
string lastName = fullName[fullName.IndexOf(' ')..]; // simplified
Console.WriteLine("lastName: {0}",lastName);

// checking for empty strings or null
bool empty = string.IsNullOrEmpty(firstName);
bool whiteSpace = string.IsNullOrWhiteSpace(lastName);
Console.WriteLine("empty: {0}",empty);








