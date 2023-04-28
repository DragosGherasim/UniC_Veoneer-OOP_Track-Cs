using System.IO;

namespace Exercise9
{
    internal class ErrorLogger
    {
        private DbContext _dbContext;

        public ErrorLogger(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Log(string errorMessage)
        {
            _dbContext.LogError(errorMessage);
            File.WriteAllText("Log.txt", errorMessage);
        }
    }
}
