using System;

void Main()
{
    Console.WriteLine("Guess the secret number!");

    int secretNumber = 47;


    for (int i = 1; i < 5; i++)
    {
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == secretNumber)
        {
            Console.WriteLine("You're right!!!");
        }
        else
        {
            Console.WriteLine("You're wrong.  Better luck next time.");
        }
    }
}

Main();