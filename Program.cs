using System;
using System.Collections.Generic;

void Main()
{
    Console.WriteLine("Difficulty? 1.Easy, 2.Medium, 3.Hard");
    int difficulty = int.Parse(Console.ReadLine());

    List<int> difficulties = new List<int> { 8, 6, 4 };
    int numberOfGuesses = difficulties[difficulty - 1];

    Console.WriteLine("Guess the secret number!");
    int secretNumber = new Random().Next(1, 101);

    for (int i = numberOfGuesses; i >= 1; i--)
    {

        Console.WriteLine($"Your Guess (Guesses left: {i}):");
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
    }





}

Main();


