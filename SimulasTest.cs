namespace Players_Guide_Tasks
{
    internal static class SimulasTest
    {
        public enum ChestStateEnum
        {
            Unknown = 0,
            Open = 1,
            Closed = 2,
            Locked = 3,
        };

        // Declare and initialize an array of ConsoleColors that matches with the ChestStateEnum's values
        private static readonly ConsoleColor[] stateColors = new ConsoleColor[] { ConsoleColor.DarkGray, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Red };

        internal static void Run()
        {
            Console.Title = "Simula's test (100XP)";

            ChestStateEnum state = ChestStateEnum.Open;

            while (true)
            {
                // Reset the console
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                // Ask a user for their command
                Console.Write("The chest is ");
                Console.ForegroundColor = stateColors[(int)state]; // <-- Explicitly convert the enum StateColorEnum to an integer and get the corresponding ConsoleColor value from the array
                Console.Write(state);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(". What do you want to do?\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("(lock/unlock/close/open): ");
                Console.ForegroundColor = ConsoleColor.White;

                // Convert the users input to a target ChestState
                // and the direction to move in order to get to that state
                (ChestStateEnum targetState, int direction) = Console.ReadLine().ToLower() switch
                {
                    "open" => (ChestStateEnum.Open, -1),
                    "close" => (ChestStateEnum.Closed, 1),
                    "lock" => (ChestStateEnum.Locked, 1),
                    "unlock" => (ChestStateEnum.Closed, -1),
                    _ => (ChestStateEnum.Unknown, 0),
                };

                // Try to change the state
                // The logic here is that the four commands needs to move either left or right
                // in order to get to their intented state. i.e.:

                // Open (1) + Unlock (-1) == Closed (2) = false
                // Locked (3) + Unlock (-1) == Closed (2) = true

                if (state + direction == targetState)
                    state = targetState; // Change the state
                else
                {
                    // Display action error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(targetState != ChestStateEnum.Unknown ? "That action is not allowed." : "Invalid input recieved.");

                    // Wait for the user to aknowledge, then continue to the next iteration of the loop
                    Console.ReadKey(true);
                }
            }

        }
    }
}