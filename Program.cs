using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");

    int secretNumber = new Random().Next(1, 101);

    for (int i = 1; i < 5; i++)
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
                Console.WriteLine($"Your guess was too high.  You have {4 - i} guesses remaining.");
            }
            else
            {
                Console.WriteLine($"Your guess was too low. You have {4 - i} guesses remaining.");

            }
        }
    }
}

Main();