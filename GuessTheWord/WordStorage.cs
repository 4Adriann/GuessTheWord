using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheWord
{
    // Written by me
    // i got help writing better strings and int, for example _words or _random. Im usually worse at picking good words
    
    internal class WordStorage
    {
        private List<string> _words = new List<string>()

        { "Bord" , "Stol", "Fönster", "Dörr",
        "Tak", "Vägg", "Golvlampa", "Soffa",
        "Matta", "Bokhylla", "Kylskåp", "Diskmaskin"
         };

        private Random _random = new Random();

        public string GetRandomWord()
        {
            int index = _random.Next(_words.Count);
            return _words[index];
        }

    }
}
