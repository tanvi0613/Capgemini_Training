using System;
namespace Exe19Dec
{
    public class PrimeNumber
    {
        /// <summary>
        /// Check if a number is prime using a for loop and break
        /// </summary>
        /// <param name="number">Input to check for prime</param>
        public static void IsPrime(int number)
        {
            int noOfDivisors = 0;
            for(int i=1; i<number/2; i++)
            {
                if(number % i == 0)
                {
                    noOfDivisors++;
                }
            }

            if(noOfDivisors == 1)
            {
                Console.WriteLine("The number is Prime");
            }
            else
            {
                Console.WriteLine("The number is not Prime");
            }
        }

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            //CHECKING FOR PRIME
            Console.WriteLine("Enter a number to check for prime: ");
            int number = Convert.ToInt32(Console.ReadLine());
            IsPrime(number);
        }
    }
}