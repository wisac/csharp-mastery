// creating new file
// File.Create("./test"); // creates test at current dir

// appending content to a file (creates file if non-existent)
File.AppendAllLines("test", ["Mango", "Oranges"]);

FileAttributes details = File.GetAttributes("test");

Console.WriteLine(details);

// copy file 
// File.Copy("test", "test3.txt");

// delete file
File.Delete("./test");

File.SetCreationTime("test3.txt", DateTime.Now);

Console.WriteLine(File.GetAttributes("test3.txt"));


// working with directories

Console.WriteLine("Created At {0}", Directory.GetCreationTimeUtc("/home/wilson/Documents/Legon"));
Console.WriteLine(Directory.GetFiles("/"));

foreach (var item in Directory.GetDirectories("/"))
{
   Console.WriteLine(item);
}

DirectoryInfo dir = new("./dir"); // initialize a new directory instance

dir.Create(); // creates new directory
Console.WriteLine(dir.Name);

// create symbolic link to folder
// File.CreateSymbolicLink("dirShort", "dir");

Console.WriteLine("Directory exist dirShort: {0}",Directory.Exists("dirShort"));

// instantiate new instance of a file
// FileInfo fl = new("file.txt");
// fl.Create();

// copy file
File.Copy("file.txt", "dir/fileCopy.txt",true); // copy and overwrite file

Console.WriteLine(Path.DirectorySeparatorChar); // /

// get all files which meet specific pattern and recursively
string[] allFiles = Directory.GetFiles("./", "*.txt", SearchOption.AllDirectories);

foreach(var file in allFiles)
   Console.WriteLine(file);
   














