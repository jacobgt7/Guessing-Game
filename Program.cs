using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");
    int userGuess = int.Parse(Console.ReadLine());

    int secretNumber = 47;

    if (userGuess == secretNumber)
    {
        Console.WriteLine("You're right!!!");
    }
    else
    {
        Console.WriteLine("You're wrong.  Better luck next time.");
    }
}

Main();