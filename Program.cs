using System;

Main();

void Main()
{
    Console.WriteLine("Can you guess the secret number?");
    Console.WriteLine("--------------------------------");

    string Guess = Console.ReadLine();
    int GuessNumber = Int32.Parse(Guess);
    int SecretNumber = 42;

    if (GuessNumber == SecretNumber)
    {
        Console.WriteLine("You got it!  Nice work!");
    }
    else
    {
        Console.WriteLine("Try again, ya big dumb babboon");
    }

}

