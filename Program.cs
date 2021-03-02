using System;

Main();


void Main()
{

    Console.WriteLine("Can you guess the secret number?");
    Console.WriteLine("--------------------------------");

    var random = new Random();
    int SecretNumber = random.Next(1, 100);
    int maxGuesses = 0;
    int currentGuess = 1;
    int guessNumber = maxGuesses - currentGuess;

    int diff;
    int chosenDifficulty = 0;

    while (chosenDifficulty == 0)
    {
        Console.WriteLine("Choose a difficulty:");
        Console.WriteLine("(1) Cheater");
        Console.WriteLine("(2) Easy");
        Console.WriteLine("(3) Medium");
        Console.WriteLine("(4) Hard");

        Console.WriteLine("Type selection here:");
        string difficulty = Console.ReadLine();
        bool newDifficulty = Int32.TryParse(difficulty, out diff);

        if (newDifficulty)
        {
            if (diff < 5 && diff > 0)
            {
                chosenDifficulty = diff;
                switch (chosenDifficulty)
                {
                    case 1:
                        maxGuesses = 100;
                        Console.WriteLine("difficulty: Cheater");
                        break;
                    case 2:
                        maxGuesses = 8;
                        Console.WriteLine("difficulty: Easy");
                        break;
                    case 3:
                        maxGuesses = 6;
                        Console.WriteLine("difficulty: Medium");
                        break;
                    case 4:
                        maxGuesses = 4;
                        Console.WriteLine("difficulty: Hard");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter a number from 1-4");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Enter a number from 1-4");
            Console.WriteLine();
        }

    }
    Console.WriteLine("Take a guess!");
    string Guess = Console.ReadLine();
    int GuessNumber = Int32.Parse(Guess);


    while (currentGuess != maxGuesses)
    {
        if (GuessNumber != SecretNumber)
        {
            if (GuessNumber < SecretNumber)
            {
                Console.WriteLine("Too Low!");

            }
            else
            {
                Console.WriteLine("Too High");

            }
            Console.WriteLine("Try again");
            Console.WriteLine($"you have {maxGuesses - currentGuess} chances left");
            currentGuess++;
            Guess = Console.ReadLine();
            GuessNumber = Int32.Parse(Guess);
        }
        else
        {
            Console.WriteLine("You got it!  Nice work!");
            break;
        }
    }
}



