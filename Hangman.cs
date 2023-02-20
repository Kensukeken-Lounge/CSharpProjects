using System;

class HangmanGame
{
    static void Main(string[] args)
    {
        string[] words = { "computer", "programming", "software", "developer", "debugger" };
        Random rand = new Random();
        string wordToGuess = words[rand.Next(words.Length)];
        char[] letters = wordToGuess.ToCharArray();
        bool[] lettersGuessed = new bool[letters.Length];
        int maxGuesses = 6;
        int guessesRemaining = maxGuesses;
        
        Console.WriteLine("Welcome to Hangman! Your word has {0} letters.", letters.Length);
        
        while (guessesRemaining > 0 && Array.IndexOf(lettersGuessed, false) >= 0)
        {
            Console.WriteLine("\nGuesses remaining: {0}", guessesRemaining);
            Console.Write("Word: ");
            
            for (int i = 0; i < letters.Length; i++)
            {
                if (lettersGuessed[i])
                {
                    Console.Write(letters[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            
            Console.Write("\nEnter a letter: ");
            char guess = Console.ReadLine().ToLower()[0];
            
            bool correctGuess = false;
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == guess)
                {
                    lettersGuessed[i] = true;
                    correctGuess = true;
                }
            }
            
            if (correctGuess)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                guessesRemaining--;
                Console.WriteLine("Incorrect!");
            }
        }
        
        if (guessesRemaining == 0)
        {
            Console.WriteLine("\nSorry, you lose! The word was: {0}", wordToGuess);
        }
        else
        {
            Console.WriteLine("\nCongratulations, you win!");
        }
        
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
