namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a string : ");
            string s = Console.ReadLine();
            Console.WriteLine("You entered : " + s);*/

            /* Console.WriteLine("Enter a username : ");
             string username = Console.ReadLine();

             Console.WriteLine("Enter a password : ");
             string pass = Console.ReadLine();

             string uss = "dragos";
             string passw = "123";

             if (username.Equals(uss) && pass.Equals(passw))
             {
                 Console.WriteLine("Login Successfull !");
             }
             else
             {
                 Console.WriteLine("Login Failed !");
             }*/

            Console.WriteLine("Enter a ch");
            char c = (char)Console.Read();

            if (char.IsLetter(c))
            {
                if (char.IsLower(c))
                {
                    Console.WriteLine("Character is lowercase");
                }
                else
                {
                    Console.WriteLine("Ch is uppercase");
                }
            }
            else
            {
                Console.WriteLine("Ch is not a letter");
            }
        }
    }
}