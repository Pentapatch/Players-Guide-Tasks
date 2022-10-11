namespace Players_Guide_Tasks
{
    internal static class TakingANumber
    {
        internal static void Run()
        {
            // Challenge: Taking a number (100XP)

            // Ask the user to input any integer number
            Console.WriteLine(AskForNumber("Enter any integer number:"));

            // Ask the user to input an integer value beween 0 and 10
            Console.WriteLine(AskForNumber("Enter a number between 0 and 10:", 0, 10));

            // Wait for the user to aknowledge, before the next iteration of the loop
            Console.ReadKey(true);
        }

        private static int AskForNumber(string message)
        {
            Console.Write(message + " ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int AskForNumber(string message, int min, int max) // <-- Note: Overloaded version
        {
            // Stay inside a loop until we are satisfied with the users input
            while (true)
            {
                int number = AskForNumber(message); // <-- Calls the other overloaded versions
                if (number >= min && number <= max) return number; // Break out of the loop and method
            }
        }
    }
}