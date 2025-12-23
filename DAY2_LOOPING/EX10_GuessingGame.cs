namespace Exe19Dec
{
    public class GuessingGame
    {
        /// <summary>
        /// Guess a secret number
        /// </summary>
        /// <param name="secret">Secret number</param>
        public void Play(int secret)
        {
            int guess;
            do
            {
                Console.WriteLine("Enter guess:");
                guess = Convert.ToInt32(Console.ReadLine());
            } while (guess != secret);

            Console.WriteLine("Correct Guess!");
        }

        public static void Main(string[] args)
        {
            GuessingGame obj = new GuessingGame();
            obj.Play(7);
        }
    }
}
