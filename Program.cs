using System;


void Main()
{
    int SecretNumber = 42;
    int UserGuess;
    Console.WriteLine("Guess a number! ");



    for (int i = 1; i < 5; i++)

    {

        UserGuess = int.Parse(Console.ReadLine());
        if (UserGuess == SecretNumber)
        {
            Console.WriteLine($"Correct! Good Guess! You got it on guess number {i}!");
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, no dice. You are on guess number {i}. Try again.");

        }
    }
}

Main();


