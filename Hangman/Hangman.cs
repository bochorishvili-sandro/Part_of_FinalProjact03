using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Hangman
    {
     
        
           public static void RunHangman()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                string[] listwords = new string[10];
                listwords[0] = "messi";
                listwords[1] = "goat";
                listwords[2] = "computer";
                listwords[3] = "mexico";
                listwords[4] = "sheep";
                listwords[5] = "icecream";
                listwords[6] = "luka";
                listwords[7] = "nika";
                listwords[8] = "orange";
                listwords[9] = "sandro";
                Random randGen = new Random();
                var randomword = randGen.Next(0, 9);
                string Word = listwords[randomword];
                char[] guess = new char[Word.Length];
                int lives = 5;



                Console.WriteLine("Game Hungrman");
                Console.WriteLine("try to guess word");
                Console.WriteLine("you have 5 lives");
                for (int p = 0; p < Word.Length; p++)
                    guess[p] = '-';
                Console.WriteLine(guess);



                while (lives > 0)
                {
                    while (true)
                    {
                        Console.WriteLine("enter letter:");
                        char playerGuess = Convert.ToChar(Console.ReadLine());
                        for (int j = 0; j < Word.Length; j++)
                        {
                            if (playerGuess == Word[j])
                                guess[j] = playerGuess;
                        }
                        Console.WriteLine(guess);
                        lives--;
                        Console.WriteLine("you have left: " + lives + "live");
                        if (true)
                        {



                        }



                        if (lives == 0)
                        {
                            Console.WriteLine("you lose");
                            Console.WriteLine("the word was:" + Word);
                            break;
                        }


                    }

                Console.ReadKey();


            }
            }
        }




    }
}
