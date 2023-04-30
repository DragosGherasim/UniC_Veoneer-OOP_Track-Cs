using System;
using System.IO;

namespace Example9
{
    internal class User
    {
        public void CreatePost(DbContext dbContext, string postMessage)
        {
            try
            {
                dbContext.Add(postMessage);
            }
            catch (Exception exception)
            {
                dbContext.LogError($"Error: {exception.Message}");
                File.WriteAllText("Log.txt", exception.Message);
            }
        }
    }
}