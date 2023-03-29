using System.Diagnostics.Metrics;
using System.Globalization;

namespace ArrayAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*prob1();

            int[,] matrix1 = { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5} };
            int[,] matrix2 = { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5} };

            prob2(matrix1, matrix1);

            
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            prob3(arr1, arr2);

            ulong[] arrL = { 10, 121, 23, 45, 253, 6, 312 };
            byte digit = 5;
            prob4(arrL, digit);

            List<string> arrS = new List<string>{ "mama", "ana", "mana", "cana", "tata" };
            string pattern = "na";
            prob5(arrS, pattern);

            prob6();*/

            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            prob7(arr1, arr2);
        }

        static void prob1()
        {
            // Write a function to read n number of values in an array and display it in reverse order. N is also read as input.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Array = {");

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("}");

            int j = arr.Length - 1;
            Console.Write("Reversed Array : { ");
            for (; j > 0; --j)
            {
                Console.Write(arr[j] + ", ");
            }
            Console.WriteLine(arr[j] + " }");


            // Print sum of elements.
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum of elements : {sum}");


            // Print occurence of specific number
            Console.Write("Target num : ");
            int target = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == target)
                {
                    ++counter;
                }
            }
            Console.WriteLine($"Num of occurence : {counter}");


            // Print all unique elements.
            Console.Write("Unique elements : ");
            int[] arrFrv = new int[9];
            for (int i = 0; i < arr.Length; ++i)
            {
                ++arrFrv[arr[i]];
            }
            for (int i = 0; i < arrFrv.Length; ++i)
            {
                if (arrFrv[i] == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void prob2(int[,] m1, int[,] m2)
        {
            // Write a function for addition of two matrices of same size N where N > 2.
            int n = m1.GetLength(0);
            int[,] sumM = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    sumM[i, j] = m1[i, j] + m2[i, j];
                }
            }

            Console.Write("Sum Matrix : ");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(sumM[i, j] + " ");
                }
            }
            Console.WriteLine();


            // Sum of diagonals.
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                    {
                        sum += sumM[i,j];
                    }
                    if (i + j == n - 1)
                    {
                        sum += sumM[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of main and secondary diagonal from sum matrix: {sum}");
        }

        static void prob3(int[] arr1, int[] arr2)
        {
            // Write a function that takes two sorted arrays of same size and merge them in ascending order.
            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; ++i)
            {
                arr3[i] = arr1[i];
            }

            int n = arr1.Length, m = arr2.Length;
            int last = m + n - 1;

            while (m > 0 && n > 0)
            {
                if (arr2[m-1] > arr3[n - 1])
                {
                    arr3[last] = arr2[m - 1];
                    --m;
                }
                else
                {
                    arr3[last] = arr3[n - 1];
                    --n;
                }

                --last;
            }

            Console.WriteLine("Merged array : ");
            for (int i=0; i < arr3.Length; ++i)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();


            //  Same output but arrays can have different sizes and they are not sorted.
            int[] ar1 = { 2, 1, 3 };
            int[] ar2 = { 4, 1, 5, 2 };

            int[] stack = new int[10];
            int top = 0;

            for (int i = 0; i < ar1.Length; ++i)
            {
                stack[top++] = ar1[i];
            }
            for(int i = 0; i < ar2.Length; ++i)
            {
                stack[top++] = ar2[i];
            }

            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < top - 1; ++i)
                {
                    if (stack[i] > stack[i + 1])
                    {
                        int temp = stack[i];
                        stack[i] = stack[i + 1];
                        stack[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);

            Console.Write("A) Merged Array : ");
            for (int i = 0; i < top; ++i)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine();


            // Add a function to insert elements into the array after the merge. Array must remain sorted.
            Console.Write("Element to insert : ");
            int target = int.Parse(Console.ReadLine());

            for(int i = 0; i < top; ++i)
            {
                if (target <= stack[i])
                {
                    for (int j = top - 1; j >= i; --j)
                    {
                        stack[j+1] = stack[j];
                    }

                    stack[i] = target;
                    top++;
                    break;
                }
            }

            Console.Write("B) Merge Array : ");
            for (int i = 0; i < top; ++i)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine();
        }

        static void prob4(ulong[] arrL, byte digit)
        {
            ulong[] aux = (ulong[])arrL.Clone();
            // Write a function that takes an array of numbers(UL) and a digit(BYTE). Now check whether the digit is present in the array of numbers.
            for (int i=0; i < aux.Length; ++i)
            {
                while (aux[i] != 0)
                {
                    if (aux[i] % 10 == digit)
                    {
                        Console.WriteLine($"The digit({digit}) is in number {aux[i]}");
                        break;
                    }

                    aux[i] /= 10;
                }
            }
            Console.WriteLine();


            // Usage of string comparison and functions allowed
            string[] arrS = new string[arrL.Length];
            for (int i = 0; i < arrS.Length; ++i)
            {
                arrS[i] = arrL[i].ToString();
            }

            char digitCh = Convert.ToChar(digit + '0'); // digitCh = 0x0035, fara + '0' -> 0x0005

            foreach (string num in arrS)
            {
                if (num.Contains(digitCh))
                {
                    Console.WriteLine($"The digit({digitCh}) is in number {num}");
                }
            }
            Console.WriteLine();
        }

        static void prob5(List<string> arrS, string patt)
        {
            // Write a function that takes a list of strings and a pattern string and finds the first string from the list that contains the pattern. ( Use LINQ )
            Console.WriteLine($"The first string that has the pattern is {arrS.FirstOrDefault(s => s.Contains(patt))}");
        }


        static void prob6()
        {
            // Write a function to read n number of values in an array and display it in reverse order. N is also read as input.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Array = {");

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("}");

            Console.Write("Reversed Array : ");
            Console.WriteLine(string.Join(", ", arr.Reverse()));
            Console.WriteLine();


            // Print sum of elements.
            Console.WriteLine($"Sum of elements : {arr.Sum()}");
            Console.WriteLine();

            // Print occurence of specific number.
            Console.Write("Target num : ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine($"Num of occurence : {arr.Count(num => num == target)}");
            Console.WriteLine();


            // Print all unique elements.
            Console.Write("Unique elements : ");
            var uniqueNums = arr.GroupBy(num => num)
                         .Where(g => g.Count() == 1)
                         .Select(g => g.Key);
           
            foreach(int num in uniqueNums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void prob7(int[] arr1, int[] arr2)
        {
            // Write a function that takes two sorted arrays of same size and merge them in ascending order
            var mergedArr = arr1.Concat(arr2).OrderBy(num => num);

            Console.WriteLine($"Merged array : {string.Join(", ", mergedArr.ToArray())}");
            Console.WriteLine();


            // Same output but arrays can have different sizes and they are not sorted
            int[] ar1 = { 2, 1, 3 };
            int[] ar2 = { 4, 1, 5, 2 };
            Console.WriteLine($"A) Merged array : {string.Join(", ", ar1.Concat(ar2).OrderBy(num => num).ToArray())}");
            Console.WriteLine();

            // Add a function to insert elements into the array after the merge. Array must remain sorted.
            List<int> arrList = mergedArr.ToList();

            arrList.Insert(4, 1);
            Console.Write("No sorted list : ");
            arrList.ForEach(num => Console.Write(num + " "));
            Console.WriteLine();

            arrList.Sort((num1, num2) => num1 - num2);
            Console.Write("Sorted list : ");
            arrList.ForEach(num => Console.Write(num + " "));
            Console.WriteLine();
        }
    }
}