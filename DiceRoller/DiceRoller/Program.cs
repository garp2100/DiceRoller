while (true)
{
    Console.WriteLine("Welcome to the Grand Circus Casino!\n");
    Console.WriteLine("How many sides should each die have");
    int sides = int.Parse(Console.ReadLine());
    int dice1;
    int dice2;
    int diceSum;

    Console.WriteLine("Press any key to roll them dies");
    Console.ReadKey();

    RollTheDice(sides);
    WinningCombinations();


    void RollTheDice(int sides)
    {
        Random random = new Random();
        //dice1 = random.Next(1, sides + 1);
        //dice2 = random.Next(1, sides + 1);

        //testing
        dice1 = 1;
        dice2 = 2;
        diceSum = dice1 + dice2;
        Console.WriteLine($"you rolled a {dice1} and a {dice2} for a total of {diceSum}");
    }

    void WinningCombinations()
    {
        if (sides == 6)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("You got Snake Eyes!");
            }
            else if (dice1 == 1 && dice2 == 2)
            {
                Console.WriteLine("You got Ace Deuce!");
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("You got Box Cars!");
            }
            else if (diceSum == 2 || diceSum == 3 || diceSum == 12)
            {
                Console.WriteLine("Craps!!");
            }
        }
    }
    while (true)
    {
        Console.WriteLine("Would you like to restart? y/n.");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            break;
        else
            Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}
