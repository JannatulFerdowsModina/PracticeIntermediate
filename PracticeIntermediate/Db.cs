namespace PracticeIntermediate
{
    public class Db
    {
        private readonly Logger _logger;
        public Db(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("Migrating...");

        }
    }
}
