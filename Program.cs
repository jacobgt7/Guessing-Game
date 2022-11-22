using System;

void Main()
{
    int numOfGuesses = 0;
    bool infiniteGuesses = false;
    while (numOfGuesses == 0 && infiniteGuesses == false)
    {
        Console.WriteLine("Choose a difficulty: Cheater | Easy | Medium | Hard");
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
            case "cheater":
                infiniteGuesses = true;
                break;
            default:
                numOfGuesses = 0;
                break;
        }
    }
    Console.WriteLine("Guess the secret number!");

    int secretNumber = new Random().Next(1, 101);

    while (numOfGuesses > 0 || infiniteGuesses == true)
    {
        int userGuess = int.Parse(Console.ReadLine());

        numOfGuesses--;

        if (userGuess == secretNumber)
        {
            Console.WriteLine("You're right!!!");
            break;
        }
        else
        {
            Console.WriteLine(secretNumber < userGuess ? "Your guess was too high." : "Your guess was too low.");
            if (infiniteGuesses == false)
            {
                Console.WriteLine($"You have {numOfGuesses} guesses remaining.");
            }
        }
    }
}

Main();