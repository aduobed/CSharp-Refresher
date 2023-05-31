
partial class Program
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Error("Migrating  Db started at " + DateTime.Now);

            _logger.Error("Migrating  Db finished at " + DateTime.Now);

        }
    }
}