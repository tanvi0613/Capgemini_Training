namespace Exe19Dec
{
    public class LargeFactorial
    {
        /// <summary>
        /// Calculate factorial of a number
        /// </summary>
        /// <param name="n">Input number</param>
        public void Calculate(int n)
        {
            System.Numerics.BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
                fact *= i;

            Console.WriteLine("Factorial = " + fact);
        }

        public static void Main(string[] args)
        {
            LargeFactorial obj = new LargeFactorial();
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.Calculate(n);
        }
    }
}
