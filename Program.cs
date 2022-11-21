using System;

void Main()
{
    int numOfGuesses = 0;
    while (numOfGuesses == 0)
    {
        Console.WriteLine("Choose a difficulty: Easy | Medium | Hard");
        string difficulty = Console.ReadLine().ToLower();
        switch (difficulty)
        {
            case "easy":
                numOfGuesses = 8;
                break;
            case "medium":
                numOfGuesses = 6;
                break;
            case "hard":
                numOfGuesses = 4;
                break;
            default:
                numOfGuesses = 0;
                break;
        }
    }
    Console.WriteLine("Guess the secret number!");

    int secretNumber = new Random().Next(1, 101);

    for (int i = 1; i <= numOfGuesses; i++)
    {
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == secretNumber)
        {
            Console.WriteLine("You're right!!!");
            break;
        }
        else
        {
            int LowOrHigh = secretNumber - userGuess;
            if (LowOrHigh < 0)
            {
                Console.WriteLine($"Your guess was too high.  You have {numOfGuesses - i} guesses remaining.");
            }
            else
            {
                Console.WriteLine($"Your guess was too low. You have {numOfGuesses - i} guesses remaining.");

            }
        }
    }
}

Main();