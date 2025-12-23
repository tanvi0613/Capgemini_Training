using System;
namespace Exe19Dec
{
    public class Fibonacci
    {
        /// <summary>
        /// Display the first N terms of the Fibonacci sequence
        /// </summary>
        /// <param name="n">Enter number till which you want the series</param>
        public static void FibonacciSeries(int number)
        {
            int sum=0;
            int prev1 = 0;
            int prev2 = 1;
            Console.Write(prev1 + " " + prev2 + " ");
            for(int i = 0; i < number; i++)
            {
                sum = prev1 + prev2;
                prev1 = prev2;
                prev2 = sum;
                Console.Write(sum + " ");
            }
        }
        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            ///CHECKING FIBONACCI SERIES
            Console.WriteLine("Enter a number till which you want the fibonacci series: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries(number);

        }
    }
}