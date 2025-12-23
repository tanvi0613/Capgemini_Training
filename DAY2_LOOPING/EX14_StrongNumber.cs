namespace Exe19Dec
{
    public class StrongNumber
    {
        /// <summary>
        /// Check if number is strong
        /// </summary>
        /// <param name="n">Input number</param>
        public void Check(int n)
        {
            int temp = n, sum = 0;

            while (temp > 0)
            {
                int d = temp % 10;
                int fact = 1;
                for (int i = 1; i <= d; i++)
                    fact *= i;
                sum += fact;
                temp /= 10;
            }

            Console.WriteLine(sum == n ? "Strong Number" : "Not Strong Number");
        }

        public static void Main(string[] args)
        {
            StrongNumber obj = new StrongNumber();
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.Check(n);
        }
    }
}
