namespace Exe19Dec
{
    public class PascalTriangle
    {
        /// <summary>
        /// Print Pascal's triangle
        /// </summary>
        /// <param name="n">Number of rows</param>
        public void PrintTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = val * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            PascalTriangle obj = new PascalTriangle();
            Console.WriteLine("Enter rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            obj.PrintTriangle(n);
        }
    }
}
