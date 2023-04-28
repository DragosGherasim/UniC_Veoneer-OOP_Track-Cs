using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Error
    {
        public void DoSomething()
        {
            object name = null;

            try
            {
                name = "ok";
                throw new StackOverflowException();
            }
            catch (StackOverflowException exception)
            {
                Console.WriteLine(exception);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                throw new Exception("Finally block is reached. ");
            }
        }
    }
}
