using System.Runtime.Intrinsics.X86;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }*/

            /*int n1 = 0, n2 = 1, n3 = n1 + n2;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < n; ++i)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            for (int i = 1; i <=6; ++i)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j + " ");
                }
            }*/

            /*string opts = "";

            do
            {
                Console.WriteLine("1. Adunare");
                Console.WriteLine("2. Scadere");
                Console.WriteLine("3. Inmultire");
                Console.WriteLine("4. Impartire");

                Console.Write("Alege optiunea : ");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            Console.Write("Nr1 = ");
                            int nr1 = int.Parse(Console.ReadLine());
                            Console.Write("Nr2 = ");
                            int nr2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Suma : {nr1 + nr2}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nr1 = ");
                            int nr1 = int.Parse(Console.ReadLine());
                            Console.Write("Nr2 = ");
                            int nr2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Scaderea : {nr1 - nr2}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nr1 = ");
                            int nr1 = int.Parse(Console.ReadLine());
                            Console.Write("Nr2 = ");
                            int nr2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Inmultirea : {nr1 * nr2}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nr1 = ");
                            int nr1 = int.Parse(Console.ReadLine());
                            Console.Write("Nr2 = ");
                            int nr2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Impartirea : {nr1 / nr2}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ati ales o optiune incorecta");
                            break;
                        }
                }

                Console.WriteLine("Doriti sa mai continuati (Da/Nu) ?");
                opts = Console.ReadLine();

            } while (opts == "Da");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < n; ++i)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum == n ? "Este perfect !" : "Nu este perfect !");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            bool ok = false;

            for (int i = 2; i <= Math.Sqrt(n); ++i)
            {
                if (n % i == 0)
                {
                    ok = true;
                }
            }

            Console.WriteLine(ok ? "Nu este prim" : "Este prim");

            Console.Write("String1 : ");
            string str1 = Console.ReadLine();
            Console.Write("String2 : ");
            string str2 = Console.ReadLine();
            string str3 = "";

            int maxLength = str1.Length > str2.Length ? str1.Length : str2.Length;

            for (int i = 0; i < maxLength; ++i)
            {
                if (i < str1.Length)
                {
                    str3 += str1[i];
                }
                if (str2.Length > i)
                {
                    str3 += str2[i];
                }
            }

            Console.WriteLine(str3);


            Console.Write("Cate stringuri vreti sa cititi : ");
            int n = int.Parse(Console.ReadLine());

            List<string> listS = new List<string>();
            for (int i=0; i < n; ++i)
            {
                Console.Write("String : ");
                string str = Console.ReadLine();

                listS.Add(str);
            }

            listS.ForEach(str =>
            {
                if (str.Length == 5)
                    Console.WriteLine(str);
            });

            Console.WriteLine(string.Join(", ", listS.Where(str => str.Length == 5).ToArray()));


            // Create a C# program that simulates a supermarket cash register to return a purchase change. Request the
            // total amount of money you have in the cash register(x) and an integer with the purchase value(y).
            // You must use 100, 50, 20, 10, 5, 2, or 1 bills and return the change using the larger bills first.
            int cashRegistAmount = 500;

            int[] bills = { 100, 50, 20, 10, 5, 2, 1 };
            int[] numBills = { 2, 2, 3, 4, 10, 15, 20 };

            Console.Write("Enter the purchase value: ");
            int purchaseVal = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("Enter the amount of money you want to pay : ");
                int amount = int.Parse(Console.ReadLine());

                if (amount < purchaseVal)
                {
                    Console.WriteLine($"Your amount is lower then purchase value {purchaseVal} ! Enter a new amount .");
                }

                int change = amount - purchaseVal;
                int funds;

                int[] billsReq = new int[bills.Length];

                if ((funds = cashRegistAmount - change) < 0)
                {
                    Console.WriteLine($"Insufficient funds in cash register ! Enter an amount lower or equal then {change + funds}.");
                    continue;
                }
                else
                {
                    int tempChange = change;

                    for (int i = 0; i <= bills.Length; ++i)
                    {
                        if (tempChange >= bills[i])
                        {
                            if ((billsReq[i] = tempChange / bills[i]) <= numBills[i])
                            {
                                tempChange -= billsReq[i] * bills[i];
                                numBills[i] -= billsReq[i];
                            }
                        }

                        if (tempChange == 0)
                        {
                            break;
                        }
                    }

                    if (tempChange == 0)
                    {
                        Console.Write($"Change (${change}) : ");

                        for (int i = 0; i < billsReq.Length; ++i)
                        {
                            if (billsReq[i] != 0)
                            {
                                Console.Write($"{billsReq[i]} X ${bills[i]} ");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient bills in cash register ! Enter other amount .");
                        continue;
                    }
                }
            }*/


            // Write a method that draws Christmas tree shape like below. Number of start on last line to be read from
            //keyboard.
            Console.Write("Enter number of stars (an odd number is recommended) : ");
            int stars = int.Parse(Console.ReadLine());

            int j = 1;
            for (int i = 1; i <= stars; i += 2)
            {
                string line = new string('*', i).PadLeft((stars/2)+j);
                ++j;
                Console.WriteLine(line);
            }
        }
    }
}