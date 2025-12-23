namespace Exe19Dec
{
    public class MenuSystem
    {
        /// <summary>
        /// Display menu using do-while
        /// </summary>
        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("1.Add  2.Sub  3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Add selected"); break;
                    case 2: Console.WriteLine("Sub selected"); break;
                }
            } while (choice != 3);
        }

        public static void Main(string[] args)
        {
            MenuSystem obj = new MenuSystem();
            obj.ShowMenu();
        }
    }
}
