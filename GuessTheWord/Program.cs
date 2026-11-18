using System.Security.Cryptography.X509Certificates;

namespace GuessTheWord
{


    // Written mostly by me. I got help making line 26 go from green to no marking on it by adding ?? "".
    // also line 21 with some symbols i forgot && !.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Gissa Ordet!");

            WordStorage wordStorage = new WordStorage();
            string word = wordStorage.GetRandomWord();
            WordGame wordGame = new WordGame(word);

            bool hasWon = false;

            while (wordGame.AttemptsLeft() > 0 && !hasWon)
            {
                Console.WriteLine($"Du har {wordGame.AttemptsLeft()} försök kvar.");
                Console.WriteLine($"Ordet är: {wordGame.GetHiddenWord()}");
                Console.WriteLine($"Blandade bokstäver: {wordGame.GetScrambledWord()}");
                Console.Write("Gissa ordet: ");
                string guess = Console.ReadLine() ?? "";
                hasWon = wordGame.Guess(guess);
                if (hasWon)
                {
                    Console.WriteLine("Grattis! Du gissade rätt!");
                }
                else
                {
                    Console.WriteLine("Fel gissning. Försök igen.");
                }
            }
            if (!hasWon)
            {
                Console.WriteLine($"Tyvärr, du har inga försök kvar. Ordet var: {wordGame.GetSecretWord()}");
            }
        }
        





    }
}
