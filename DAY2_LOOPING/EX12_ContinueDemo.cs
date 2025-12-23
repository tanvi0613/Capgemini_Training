namespace Exe19Dec
{
    public class ContinueDemo
    {
        /// <summary>
        /// Print numbers skipping multiples of 3
        /// </summary>
        public void Print()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                    continue;

                Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            ContinueDemo obj = new ContinueDemo();
            obj.Print();
        }
    }
}
