using  System;
using static Wordle.WordGen;

namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Green, "Wordle Game: Version 1.0.0 by ID Titanium");
            Console.WriteLine("Welcome to Wordle, the word guessing game. Enter your name");
            string input = Console.ReadLine();
            while(input == null) {
                Console.WriteLine("Welcome to Wordle, the word guessing game. Enter your name");
                input = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0} ! Goodluck, Enter your first guess!", input);
            int wordLen = 5;
            string correctWord = WordGen.release().ToUpper();
            string randomGuess = "Wrong";
            while (randomGuess != correctWord) {
                randomGuess =  Console.ReadLine().ToUpper();
                if(randomGuess == null || randomGuess.Length > 5) {
                    PrintColorMessage(ConsoleColor.Red, "Incorrect word length, only "+ wordLen +" allowed");
                    continue;
                }
                if(randomGuess == "!") {
                    Console.WriteLine(correctWord);
                }
                if(randomGuess != correctWord) {
                    for (int count = 0; count < randomGuess.Length; count++) {
                        if(randomGuess[count] == correctWord[count]) {
                            PrintColorChar(ConsoleColor.Green, randomGuess[count]);
                            continue;
                        }else if (correctWord.IndexOf(randomGuess[count]) > -1) {
                            PrintColorChar(ConsoleColor.Yellow, randomGuess[count]);
                        }else {
                            PrintColorChar(ConsoleColor.Red, randomGuess[count]);
                        }
                    }
                    Console.WriteLine("\n");
                    PrintColorMessage(ConsoleColor.Red, "Incorrect word, try again");
                }
            }
            PrintColorMessage(ConsoleColor.Green, randomGuess);
            Console.WriteLine("Correct!");
        }

        static void PrintColorMessage(ConsoleColor color, string message) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintColorChar(ConsoleColor color, char c)
        {
            Console.ForegroundColor = color;
            Console.Write(c);
            Console.ResetColor();
        }
    }
}