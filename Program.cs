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
            break;
        }
        else
        {
            Console.WriteLine($"Try again. Your guess ({i + 1})");
        }
    }
}

Main();