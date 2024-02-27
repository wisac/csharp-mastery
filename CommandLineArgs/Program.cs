// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n {0}", sum());
Console.WriteLine(args);
foreach (var item in args)
{
   Console.WriteLine(item);
}


double sum()
{
   double sum = default;
   foreach (var input in args[0..2])
   {
      sum += double.Parse(input);
   }

   return sum;
}

// The Environment class has methods which provide information about the environment the current process is running in. 

string[] inputs = Environment.GetCommandLineArgs();
foreach (string input in inputs)
{
   System.Console.WriteLine("input: {0}", input);
}
foreach (var item in Environment.GetEnvironmentVariables())
{

   Console.WriteLine("var: {0}", item);
}


Console.WriteLine("OS: {0}", Environment.OSVersion);
Console.WriteLine("Number of processors: {0}",
Environment.ProcessorCount);
Console.WriteLine(".NET Core Version: {0}",
Environment.Version);