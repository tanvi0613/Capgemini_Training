namespace Exe19Dec
{
    public class GotoSearch
    {
        /// <summary>
        /// Search element using goto
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="key">Search key</param>
        public void Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] == key)
                        goto FOUND;

            Console.WriteLine("Not Found");
            return;

        FOUND:
            Console.WriteLine("Element Found");
        }

        public static void Main(string[] args)
        {
            GotoSearch obj = new GotoSearch();
            int[] arr = { 1, 4, 6, 8, 9 };
            obj.Search(arr, 6);
        }
    }
}
