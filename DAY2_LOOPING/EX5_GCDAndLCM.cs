namespace Exe19Dec
{
    public class GcdLcm
    {
        /// <summary>
        /// Calculate GCD and LCM of two numbers
        /// </summary>
        /// <param name="num1">First number</param>
        /// <param name="num2">Second number</param>
        public void Calculate(int num1, int num2)
        {
            int x = num1, y = num2;
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            int gcd = x;
            int lcm = (num1 * num2) / gcd;

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }

        public static void Main(string[] args)
        {
            GcdLcm obj = new GcdLcm();
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            obj.Calculate(num1, num2);
        }
    }
}
