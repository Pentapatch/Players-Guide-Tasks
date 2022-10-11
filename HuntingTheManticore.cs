internal static class ManticoreGame
{
    internal static void Run()
    {
        // Declare and initialize variables
        int cityHealth = 15;
        int manticoreHealth = 10;
        int manticoreDistance = -1;
        int round = 0;

        // Run the game until either the city- or manticore health reaches 0 or below
        while (cityHealth > 0 && manticoreHealth > 0)
        {
            // Print the player turn separator
            PrintTurnSeparator(round);

            // Check if it is player 1 or player 2's turn
            if (round == 0)
            {
                // Player 1's turn
                manticoreDistance = AskForNumber("Enter the distance from the city that you wish to place the Manticore (0-100):", 0, 100);
                Console.Clear();
            }
            else
            {
                // Player 2's turn
                // Print a status header with info about the current round, the manticores health and the city's health
                PrintStatusHeader(round, manticoreHealth, cityHealth);

                // Ask player 2 for a cannon range to try
                int cannonRange = AskForNumber("Enter the desired range of the next cannon shot (0-100):", 0, 100);

                // Check if player 2 guessed the correct number
                bool manticoreWasHit = cannonRange == manticoreDistance;
                if (manticoreWasHit)
                {
                    // Direct hit: Let the user know
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That was a direct hit!");

                    // Get the damage and decrement the health of the manticore
                    // Note: If performance was an issue, I would have calculated this only once in the top of the loop (not in multiple places)
                    manticoreHealth -= GetShotInfo(round).Damage;
                }
                else
                {
                    // Miss: Let the user know
                    string cannonCorrectionString = cannonRange < manticoreDistance ? "fell short of" : "overshot";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"That round {cannonCorrectionString} the target!");
                }

                // Beep (higher pitch if the manticore was hit)
                Console.Beep(manticoreWasHit ? 720 : 480, 100);

                // Decrement the city health by 1 (if the manticore is still alive)
                if (manticoreHealth > 0) cityHealth--;

                Console.WriteLine(); // Add a blank row
                Thread.Sleep(200); // Sleep for 100ms
            }

            // Increment the current round and begin the next iteration of the loop
            round++;
        }

        // The game is over: Check who won
        PrintGameOver(manticoreHealth, cityHealth);

        // Wait for the user to aknowledge, then exit
        Console.ReadKey(true);
    }

    // Private helper methods

    private static void PrintStatusHeader(int round, int manticoreHealth, int cityHealth)
    {
        // Set up the console color
        Console.ForegroundColor = ConsoleColor.White;

        // Print the status
        Console.WriteLine($"STATUS: Round: {round} | Manticore health: {manticoreHealth} | City health: {cityHealth}");

        // Calculate and print the expected damage
        (int Damage, string ShotType, ConsoleColor Color) = GetShotInfo(round);
        Console.Write("The cannon is expected to produce a ");
        Console.ForegroundColor = Color;
        Console.Write(ShotType);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" shot and deal {Damage} damage.\n");

        // Print separator
        PrintSeparator(70 + 16); // The + 16 is there to account for the "Player X's turn " string so we match the length of the two separators
    }

    private static void PrintTurnSeparator(int round)
    {
        // Set the color to red for player 1 or blue for player 2
        Console.ForegroundColor = round == 0 ? ConsoleColor.Red : ConsoleColor.Blue;

        // Print the player number to the console
        Console.Write("Player " + (round == 0 ? 1 : 2) + "'s turn ");

        // Print a separator line
        PrintSeparator(70, false);
    }

    private static void PrintSeparator(int length, bool gray = true)
    {
        if (gray) Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(new string('-', length) + "\n");
    }

    private static void PrintGameOver(int manticoreHealth, int cityHealth)
    {
        Console.Clear();
        if (manticoreHealth <= 0)
        {
            // Player 2 (the city) won
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The manticore was destroyed!");
            Console.ForegroundColor = ConsoleColor.White;
            string cityState = cityHealth <= 5 ? "was severly damaged, but " : "";
            Console.WriteLine($"The city of Consolas {cityState}has been saved.");
        }
        else
        {
            // Player 1 (the manticore) won
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The city was destroyed!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The manticore overpowered the city of Consolas.");
        }
    }

    private static (int Damage, string ShotType, ConsoleColor Color) GetShotInfo(int round)
    {
        return (round % 3, round % 5) switch
        {
            (0, 0) => (10, "supercharged", ConsoleColor.Blue),
            (_, 0) => (3, "electric", ConsoleColor.Yellow),
            (0, _) => (3, "fire", ConsoleColor.Red),
            (_, _) => (1, "standard", ConsoleColor.DarkGray)
        };
    }

    private static int AskForNumber(string message)
    {
        // Does intentionally not handle errors since this will probably come later in the book
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(message + " ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int AskForNumber(string message, int min, int max)
    {
        while (true)
        {
            // Ask the user to input a number
            int number = AskForNumber(message);

            // Break out of the loop and return the value if it is within the specified range
            if (number >= min && number <= max) return number;
        }
    }

}