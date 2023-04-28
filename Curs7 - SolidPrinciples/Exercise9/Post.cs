using System;

namespace Exercise9
{
    internal class Post
    {
        private ErrorLogger _errorLogger;

        public void CreatePost(DbContext dbContext, string postMessage)
        {
            try
            {
                dbContext.Add(postMessage);
            }
            catch (Exception exception)
            {
                _errorLogger = new ErrorLogger(dbContext);
                _errorLogger.Log(exception.Message);
            }
        }
    }
}
