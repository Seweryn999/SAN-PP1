using System;

Random random = new Random();
int randomNumber = random.Next(1, 51);
int attempts = 7;
bool hasWon = false;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I have chosen a number between 1 and 50.");
Console.WriteLine("You have 7 attempts to guess it correctly. Let's begin!");

for (int i = 0; i < attempts; i++)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();
    int userGuess;

    if (!int.TryParse(input, out userGuess) || userGuess < 1 || userGuess > 50)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 50.");
        continue;
    }

    if (userGuess < randomNumber)
    {
        Console.WriteLine("Too low!");
    }
    else if (userGuess > randomNumber)
    {
        Console.WriteLine("Too high!");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        hasWon = true;
        break;
    }
}

if (!hasWon)
{
    Console.WriteLine($"Sorry! You've used all attempts. The correct number was {randomNumber}.");
}

Console.WriteLine("Thank you for playing!");
