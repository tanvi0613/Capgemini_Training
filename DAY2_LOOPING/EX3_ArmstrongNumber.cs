using System;
namespace Exe19Dec
{
    public class ArmstrongNumber
    {
        /// <summary>
        /// Check if a number equals the sum of its digits raised to the power of number of digits
        /// </summary>
        /// <param name="number">Input to check for armstrong</param>
        public static void IsArmstrongNumber(int number)
        {
            int numberCopy = number;
            int numOfDigits = 0;
            int sumOfDigits=0;

            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                numOfDigits++;
                numberCopy/=10;
            }

            numberCopy = number;

            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                sumOfDigits += (int)Math.Pow(digit, numOfDigits);
                numberCopy /= 10;
            }

            if(sumOfDigits == number)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            //ARMSTRONG NUMBER
            Console.WriteLine("Enter a number to check for armstrong: ");
            int number = Convert.ToInt32(Console.ReadLine());
            IsArmstrongNumber(number);
        }
    }
}