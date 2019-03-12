using System;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("The prime numbers between " + x + " and " + y + " are:");
                int i;
                int r;
                for (i = x; i <= y; i++)
                {
                    bool isPrime = true;
                    for (r = 2; r <= y; r++)
                    {
                        if (i != r
                           &&
                           i % r == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("\t" + i);
                    }
                }


            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double factor(int n)
        {
            int i;
            int fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = i * fact;

            }
            return fact;
        }
        public static double getSeriesResult(int n)
        {
            try
            {
                int i;
                double total, r;
                total = 0;
                for (i = 1; i <= n; i++)
                {
                    r = Math.Pow((-1), (i + 1)) * factor(i) / (i + 1);
                    total = total + r;
                }
                return Math.Round(total, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int i, rows, space, brk;
                for (i = 1; i <= n; i++)
                {
                    for (space = i + 1; space <= n + 1; space++)
                    {
                        Console.Write(" ");
                    }
                    for (rows = 0; rows < 2 * i - 1; rows++)
                    {
                        Console.Write("*");
                    }
                    for (brk = 1; brk < 2; brk++)
                    {
                        Console.Write("\n");
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        //int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2, 9 };
        public static void computeFrequency(int[] a)
        {
            try
            {
                int maxVal = a.Max();
                int[] arr = new int[maxVal * maxVal];
                for (int x = 0; x <= maxVal; x++)
                {
                    for (int y = 0; y < a.Length; y++)
                    {
                        if (a[y] == x)
                            arr[x]++;

                    }
                }
                Console.WriteLine("Number" + "  " + "Frequency");
                for (int x = 0; x <= maxVal; x++)
                    Console.WriteLine(x + "       " + arr[x]);
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
