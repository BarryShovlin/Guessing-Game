using System;

Main();


void Main()
{

    Console.WriteLine("Can you guess the secret number?");
    Console.WriteLine("--------------------------------");

    var random = new Random();
    int SecretNumber = random.Next(1, 100);
    int guessNumber = 4;
    int maxGuesses = 0;
    int diff;
    int chosenDifficulty = 0;

    while (chosenDifficulty == 0)
    {
        Console.WriteLine("Choose a difficulty:");
        Console.WriteLine("[1] Cheater");
        Console.WriteLine("[2] Easy");
        Console.WriteLine("[3] Medium");
        Console.WriteLine("[4] Hard");

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
                        Console.WriteLine("You chose difficulty: Cheater");
                        Console.WriteLine();
                        break;
                    case 2:
                        maxGuesses = 8;
                        Console.WriteLine("You chose difficulty: Easy");
                        Console.WriteLine();
                        break;
                    case 3:
                        maxGuesses = 6;
                        Console.WriteLine("You chose difficulty: Medium");
                        Console.WriteLine();
                        break;
                    case 4:
                        maxGuesses = 4;
                        Console.WriteLine("You chose difficulty: Hard");
                        Console.WriteLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid difficulty [1-4]");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid difficulty [1-4]");
            Console.WriteLine();
        }

    }
    Console.WriteLine("Take a guess!");
    string Guess = Console.ReadLine();
    int GuessNumber = Int32.Parse(Guess);


    while (guessNumber < maxGuesses)
    {
        if (GuessNumber != SecretNumber)
        {
            if (GuessNumber < SecretNumber)
            {
                Console.WriteLine("Too Low!");
                guessNumber++;
            }
            else
            {
                Console.WriteLine("Too High");
                guessNumber++;
            }
            Console.WriteLine("Try again");
            Console.WriteLine($"you have {maxGuesses - guessNumber} chances left");
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



