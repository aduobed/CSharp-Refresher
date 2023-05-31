partial class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welome to Db Migrator");

        var dbMigration = new DbMigrator(new FileLogger("C:\\Project\\log.txt"));
        dbMigration.Migrate();
    }
}