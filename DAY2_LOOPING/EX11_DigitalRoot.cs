namespace Exe19Dec
{
    public class DigitalRoot
    {
        /// <summary>
        /// Calculate digital root of a number
        /// </summary>
        /// <param name="n">Input number</param>
        public void Calculate(int n)
        {
            while (n >= 10)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }
            Console.WriteLine("Digital Root = " + n);
        }

        public static void Main(string[] args)
        {
            DigitalRoot obj = new DigitalRoot();
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.Calculate(n);
        }
    }
}
