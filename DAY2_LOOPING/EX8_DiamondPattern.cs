namespace Exe19Dec
{
    public class DiamondPattern
    {
        /// <summary>
        /// Print diamond pattern
        /// </summary>
        /// <param name="n">Number of rows</param>
        public void Print(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }

        public static void Main(string[] args)
        {
            DiamondPattern obj = new DiamondPattern();
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.Print(n);
        }
    }
}
