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

        public WordGame(string secretWord)
        {
            _secretWord = secretWord;
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

            if (_attemptsLeft < _secretWord.Length - 1)
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
    }
}
