using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");

    int secretNumber = new Random().Next(1, 101);
    Console.WriteLine(secretNumber);

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
            Console.WriteLine($"Try again. You have {4 - i} guesses remaining.");
        }
    }
}

Main();