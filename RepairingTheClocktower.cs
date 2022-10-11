namespace Players_Guide_Tasks
{
    internal static class RepairingTheClocktower
    {
        internal static void Run()
        {
            // Challenge: Repairing the clocktower (100XP)

            // Stay in a loop indefinitely
            while (true)
            {
                // Clear the console
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                // Ask the user to enter any number, then store it as a variable
                Console.Write("Enter any number: ");
                int answerInt = Convert.ToInt32(Console.ReadLine());

                // Print either Tick or Tock depending on if the number is even or odd
                Console.WriteLine(answerInt % 2 == 0 ? "Tick." : "Tock.");

                // Wait for the user to aknowledge
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to try again..");
                Console.ReadKey(true);
            }
        }
    }
}