using System;
using System.Collections.Generic;

void Main()
{
    Console.WriteLine("Difficulty? 1.Easy, 2.Medium, 3.Hard 4.Cheater:");
    int difficulty = int.Parse(Console.ReadLine());

    List<int> difficulties = new List<int> { 8, 6, 4, 2 };
    int numberOfGuesses = difficulties[difficulty - 1];

    int guessesLeft = numberOfGuesses;
    Console.WriteLine("Guess the secret number!");
    int secretNumber = new Random().Next(1, 101);

    while (difficulty == 4 || guessesLeft > 0)
    {

        Console.WriteLine($"Your Guess (Guesses left: {(difficulty == 4 ? "Infinite" : guessesLeft)}):");
        int answer = int.Parse(Console.ReadLine());
        if (secretNumber == answer)
        {
            Console.WriteLine("correct!");
            break;
        }
        else
        {
            Console.WriteLine(secretNumber > answer ? "too low!" : "too high!");
        }

        guessesLeft--;
    }





}

Main();


