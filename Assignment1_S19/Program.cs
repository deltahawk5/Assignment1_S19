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

            // some challenging problems that would have been more solvable if I had increased familiarity with c# and refreshed
            // other comp sci concepts, xmas/tree was particularly interesting and took longer to resolve than expected
            // in terms of figuring out how to space values in order to reflect correct shape

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("The prime numbers between " + x + " and " + y + " are:");
                //define vars
                int i;
                int r;
                //iterate based on range
                for (i = x; i <= y; i++)
                {
                    //check if # is prime
                    bool isPrime = true;
                    for (r = 2; r <= y; r++)
                    {
                        //check if # not equal to self or zero
                        if (i != r && i % r == 0)
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
            //calculate factorial
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
                //iterate thru series calc calling factorial funct for i
                for (i = 1; i <= n; i++)
                {
                    r = Math.Pow((-1), (i + 1)) * factor(i) / (i + 1);
                    total = total + r;
                }
                //return output rounded 3 dec places
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
                //define vars
                int i, rows, space, brk;
                //iterate based on range max
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

        public static void computeFrequency(int[] a)
        {
            try
            {
                //find highest value in array
                int maxVal = a.Max();
                //define array and array size based on max value sqrd
                int[] arr = new int[maxVal * maxVal];
                //create loop to run # of times based on array item count
                for (int x = 0; x <= maxVal; x++)
                {
                    //iterate thru each array item
                    for (int y = 0; y < a.Length; y++)
                    {
                        //count array instance and sum to counter
                        if (a[y] == x)
                            arr[x]++;

                    }
                }
                //print results for-loop
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
