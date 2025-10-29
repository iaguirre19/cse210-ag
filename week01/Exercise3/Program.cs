using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        Random randomGuesser = new Random();
        do
        {
            int magicNumber = randomGuesser.Next(1, 30);
            int guessNumber;
            Console.WriteLine("Let's play! Guess the magic number between 1 and 100.");
            do
            {
                Console.Write("What is the Magic Number?: ");
                string userInput = Console.ReadLine();
                guessNumber = int.Parse(userInput);

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guessNumber != magicNumber);

            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();
        } while (response == "yes");

    }
}