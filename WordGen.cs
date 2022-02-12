using System;

namespace Wordle 
{
    class WordGen
    {
        public static string release()
        {
            Random random = new Random();
            string word = GetWords()[random.Next(0,6)];
            return word;
        }

        private static string[] GetWords()
        {
            string[] words = {"titus", "hello", "world", "trial", "tramp", "small", "arial"};
            return words;
        }
    }
}