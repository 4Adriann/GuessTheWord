using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GuessTheWord
{
    // Got a lot of help by claude in this one in general especially the ifs, i also got help here using better words
    // like _secretWord for example.
    // I got help from claude in GetHiddenWord and with the bool. The bool used to 
    // give hints every time and even if you already had the word revealed it kept giving hints.
    // claude helped me fix that.
    internal class WordGame
    {
        private string _secretWord;
        private int _attemptsLeft;
        private int _lettersShown;
        private string _scrambledWord;

        public WordGame(string secretWord)
        {
            _secretWord = secretWord;
            _scrambledWord = ShuffleLetters(secretWord);
            _attemptsLeft = 5;
            _lettersShown = 1;

        }

        public string GetHiddenWord()
        {
            string result = "";

            
            for (int i = 0; i < _secretWord.Length; i++)
            {
                if (i < _lettersShown)
                {
                    result += _secretWord[i] + " ";
                }
                else
                {
                    result += "_ ";
                }
            }
            return result;
            
            
            
        }

        public bool Guess(string guess)
        {
            if (guess.ToLower() == _secretWord.ToLower())
            {
                return true;
            }

            _attemptsLeft--;

            if (_lettersShown < _secretWord.Length - 1)
            {
                _lettersShown++;
            }
            
            return false;


        }
        public int AttemptsLeft()
        {
           { return _attemptsLeft; }
        }

        public string GetSecretWord()
        {
            return _secretWord;
        }

        // Claude helped me fix the problem that the words scrambled showed which letter came first by it being big. Hint still shows first letter but thats fine. 
        public string GetScrambledWord()
        {
            return _scrambledWord;
        }
        private string ShuffleLetters(string word)
        {
            char[] letters = word.ToLower().ToCharArray();
            Random random = new Random();
            for (int i = letters.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                char temp = letters[i];
                letters[i] = letters[j];
                letters[j] = temp;
            }
            return new string(letters);
        }
    }
}
