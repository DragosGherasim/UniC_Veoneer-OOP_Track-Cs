using System.Linq.Expressions;
using System.Security.Cryptography;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var error = new Error();
                error.DoSomething();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                try
                {
                    var clock = new Clock();
                    clock.ShowTime();
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    try
                    {
                        var clock = new Clock();
                        clock.CanShowTime = true;
                        clock.ShowTime();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}