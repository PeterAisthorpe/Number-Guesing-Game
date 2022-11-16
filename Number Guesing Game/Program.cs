using System;

namespace Number_Guesing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumb = new Random();

            int winnningNumber = ranNumb.Next(1, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number and see if you're right! The number is between 1 and 100");
                string guess = Console.ReadLine();

                int userGuess = int.Parse(guess);
                if (userGuess == winnningNumber)
                {
                    Console.WriteLine("Well done you won");
                    win = true;
                }
                else if (userGuess > winnningNumber)
                {
                    Console.WriteLine("Too high, guess again");
                }
                else if (userGuess < winnningNumber)
                {
                    Console.WriteLine("Too low, guess again");
                }
            } while (win == false);

        }
    }
}

//this program was my first created with help in 2021. I am now working to relearn prograaming after a break
