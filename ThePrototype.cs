namespace Players_Guide_Tasks
{
    internal static class ThePrototype
    {
        internal static void Run()
        {
            // Challenge: The prototype (100XP)

            int targetNumber = -1; // Important: Initialize this value to a value that fails to complete the conditions when entering the while loop below

            // Stay in a loop until the targetNumber is set to between 0 and 100
            while (targetNumber < 0 || targetNumber > 100)
            {
                // Ask user 1 to enter any number between 0 and 100, then store it in a the targetNumber variable
                Console.ForegroundColor = ConsoleColor.Red;
                targetNumber = AskForNumberInRange("User 1: Enter a number between 0 and 100:", 0, 100);
            }

            // Print instructions for user 2
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("User 2: Guess the number (0 - 100) selected by user 1:");

            int numberGuessed = -1; // Important: Initialize this value to a value that fails to complete the conditions when entering the while loop below

            // Stay in a loop until user 2 guesses the right number
            while (numberGuessed != targetNumber)
            {
                // Ask the user to enter a number, then store it in the numberGuessed variable
                Console.ForegroundColor = ConsoleColor.White;
                numberGuessed = AskForNumberInRange("What's your guess?", 0, 100);

                // Check if the answer is too low, too high or correct
                Console.ForegroundColor = ConsoleColor.Red;
                if (numberGuessed == targetNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You guessed correctly! {numberGuessed} is the correct number.");
                }
                else if (numberGuessed < targetNumber)
                    Console.WriteLine($"The number {numberGuessed} is too low.. Try again.");
                else
                    Console.WriteLine($"The number {numberGuessed} is too high.. Try again.");
            }

            // Wait for the user to aknowledge before the next iteration of the loop
            Console.ReadKey(true);

            // Note: I have declared these two methods inside the Run method (will only be able to use these methods from within this Run method)
            static int AskForNumber(string message) // <-- Compiler warning because it is not being used (could be removed)
            {
                Console.Write(message + " ");
                return Convert.ToInt32(Console.ReadLine());
            }

            static int AskForNumberInRange(string message, int min, int max) // Could use overloaded method here (i.e. rename this method to AskForNumber) if declared outside of the Run method
            {
                while (true)
                {
                    Console.Write(message + " ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number >= min && number <= max) return number;
                }
            }
        }
    }
}