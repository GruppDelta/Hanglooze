using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static string playerName;
        static string secretWord = "banan";
        static char[] maskedWord;
        static int playerLives;

        static void Main(string[] args)
        {
            StartGame();

            PlayGame();

            EndGame();
        }

        static void StartGame()
        {

            maskedWord = new char[secretWord.Length];
            for (int i = 0; i < maskedWord.Length; i++)
            {
                maskedWord[i] = '-';
            }

            AskForName();

        }

        static void AskForName()
        {
            Console.WriteLine("Ange ditt namn:");
            string input = Console.ReadLine();

            if (input.Length < 2)
                AskForName();
            else
                playerName = input;
           
        }

        static void PlayGame()
        {

            do
            {
                DisplayMaskedWord();
                AskForCharacter();
            } while (secretWord != new string (maskedWord));

            DisplayMaskedWord();
           

        }
        static void DisplayMaskedWord()
        {

            for (int i = 0; i < maskedWord.Length; i++)
                Console.Write(maskedWord[i]);

            Console.WriteLine(" ");
        }

        static void AskForCharacter()
        {
                string input;

                do
                {
                    Console.WriteLine("Gissa på ett tecken i ordet");
                    input = Console.ReadLine();
                } while (input.Length != 1);

            char inputChar = input[0];

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == inputChar)
                    maskedWord[i] = inputChar;
            }
        }

        static void EndGame()
        {
            Console.WriteLine("Tack för spelet " + playerName);
        }
    }
}
