using Demo;

DbMigrator dbMigrator = new(new ConsoleLogger());
dbMigrator.Migrate();

DbMigrator dbMigrator1 = new(new FileLogger("./log.txt"));
dbMigrator1.Migrate();