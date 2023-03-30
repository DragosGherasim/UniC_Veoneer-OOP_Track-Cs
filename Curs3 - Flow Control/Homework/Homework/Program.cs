namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*prob1();

            prob2();

            prob3();

            prob4();*/

            prob5();
        }

        static void prob1()
        {
            // Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            int[] arr = new int[10];

            Console.WriteLine("Array : { ");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("}");

            Console.WriteLine($"Sum of nums : {arr.Sum()}");
            Console.WriteLine($"Average of nums : {arr.Average()}");
        }

        static void prob2()
        {
            Console.Write("Side1 length : ");
            int sd1 = int.Parse(Console.ReadLine());

            Console.Write("Side2 length : ");
            int sd2 = int.Parse(Console.ReadLine());

            Console.Write("Side3 length : ");
            int sd3 = int.Parse(Console.ReadLine());

            if ((sd1 + sd2 > sd3) || (sd1 + sd3 > sd2) || (sd2 + sd3 > sd1))
            {
                if ((sd1 == sd2) && (sd2 == sd3))
                {
                    Console.WriteLine("Equilateral triangle !");
                }
                else if ((sd1 == sd2) || (sd1 == sd3) || (sd2 == sd3))
                {
                    Console.WriteLine("Isosceles triangle !");
                }
                else if ((sd3 == Math.Sqrt(Math.Pow(sd1, 2) + Math.Pow(sd2, 2))) ||
                    (sd2 == Math.Sqrt(Math.Pow(sd1, 2) + Math.Pow(sd3, 2))) ||
                    sd1 == Math.Sqrt(Math.Pow(sd2, 2) + Math.Pow(sd3, 2)))
                {
                    Console.WriteLine("Right triangle !");
                }
                else
                {
                    Console.WriteLine("Scalene triangle !");
                }
            }
            else
            {
                Console.WriteLine("Not triangle !");
            }
        }

        enum Months { January = 1, February, March, April, May, June, July }
        static void prob3()
        {
            int num;
            do
            {
                Console.Write("Num : ");
                num = int.Parse(Console.ReadLine());

            } while (num < 1 || num > 12);

            Console.WriteLine($"The corresponding month for {num} is {(Months)num}");
        }

        static void prob4()
        {
            // Read a string from the keyboard and print it in reverse order, each character on a new line.
            Console.Write("String : ");
            string str = Console.ReadLine();

            Console.WriteLine($"String diplay : {str}");
            Console.WriteLine("Reversed string : ");
            Console.Write(string.Join("\n", str.Reverse()));
        }

        static void prob5()
        {
            // Prompt the user to enter a value between 0 and 10. The loop should continue until the user enters a valid value.
            int num;
            do
            {
                Console.Write("Enter a value between 0 and 10 : ");
                num = int.Parse(Console.ReadLine());
            } while (num < 0 || num > 10);

            Console.WriteLine($"You entered a valid value ({num}) !");
        }
    }
}