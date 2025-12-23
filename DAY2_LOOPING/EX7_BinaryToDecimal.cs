namespace Exe19Dec
{
    public class BinaryToDecimal
    {
        /// <summary>
        /// Convert binary string to decimal
        /// </summary>
        /// <param name="bin">Binary string</param>
        public void Convert(string bin)
        {
            int dec = 0, power = 1;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                dec += (bin[i] - '0') * power;
                power *= 2;
            }

            Console.WriteLine("Decimal = " + dec);
        }

        public static void Main(string[] args)
        {
            BinaryToDecimal obj = new BinaryToDecimal();
            Console.WriteLine("Enter binary number:");
            string? b = Console.ReadLine();
            obj.Convert(b);
        }
    }
}
