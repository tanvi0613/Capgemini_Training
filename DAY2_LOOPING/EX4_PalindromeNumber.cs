using System;
namespace Exe19Dec
{
    public class PalindromeNumber
    {
        /// <summary>
        /// Reverse an integer and check if it is a palindrome
        /// </summary>
        /// <param name="number">Input a number to check for palindrome</param>
        public static void IsPalindromeNumber(int number)
        {
            int numberCopy = number;
            int reversedNumber = 0;
            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                reversedNumber = reversedNumber * 10 + digit;
                numberCopy/=10;
            }

            if(reversedNumber == number)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            //PALINDROME NUMBER
            Console.WriteLine("Enter a number to check for palindrome: ");
            int number = Convert.ToInt32(Console.ReadLine());
            IsPalindromeNumber(number);
        }
    }
}