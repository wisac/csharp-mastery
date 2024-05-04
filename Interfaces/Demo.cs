namespace Demo;
using System.IO;
public interface ILogger
{
   void LogInfo(string message);
   void LogError(string message);
}


public class DbMigrator
{
   private readonly ILogger _logger;
   public DbMigrator(ILogger logger)
   {
      _logger = logger;
   }
   public void Migrate()
   {
      _logger.LogInfo("Migration started at " + DateTime.Now);
   }

}

public class ConsoleLogger : ILogger
{
   public void LogError(string message)
   {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine(message);

   }

   public void LogInfo(string message)
   {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine(message);

   }
}

public class FileLogger : ILogger
{
   private readonly string _path;

   public FileLogger(string path)
   {
      _path = path;
   }
   public void LogError(string message)
   {
      Log(message, "ERROR");
   }

   public void LogInfo(string message)
   {
      Log(message, "INFO");
   }

   private void Log(string message, string messageType)
   {
      using StreamWriter streamWriter = new(_path);
      streamWriter.WriteLine(messageType + " : " + message);
   }
}