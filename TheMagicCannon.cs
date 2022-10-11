namespace Players_Guide_Tasks
{
    internal static class TheMagicCannon
    {
        public enum TypeOfShotEnum
        {
            Default = 0,
            Fire,
            Electric,
            Supercharged,
            //Symbolic, // <-- Uncomment this, line 15 and line 43 to test with more types
        };

        // The following field contains the ConsoleColor value that I want to match with the TypeOfShotEnum value
        private static ConsoleColor[] ShotTypeColor = new ConsoleColor[] { ConsoleColor.DarkGray, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue, /*ConsoleColor.Cyan*/ };

        internal static void Run()
        {
            // Challenge: The magic cannon (100XP)

            // Stay in a loop indefinitely
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                // Declare and initialize an array of integers, with the size of the number of shot types (should be 4, but I have made the declaration dynamic, if additional types should be added to the array)
                // I will use this for counting the number of times any particular type of shot was fired (for statistics)
                int[] shotCounter = new int[Enum.GetNames(typeof(TypeOfShotEnum)).Length]; // <-- Enum.GetNames returns an array with all the members of the enum and .Length is the size of that array

                // Ask the user how many shots that will be fired, then store the answer in a variable
                Console.Write("How many shots will be fired? ");
                int numberOfShotsFired = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // Loop shotsFired amount of times
                for (int i = 1; i <= numberOfShotsFired; i++)
                {
                    // Calculate the type of shot that is being produces by using the modulus operator
                    TypeOfShotEnum shotType = TypeOfShotEnum.Default;
                    if (i % 3 == 0) shotType += 1; // Note: This works because the enums underlying type is int
                    if (i % 5 == 0) shotType += 2; //       --"--
                    //if (i == 50) shotType = TypeOfShotEnum.Symbolic;

                    // Print the current turn to the console
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Turn {i}: ");

                    // Increment the array member (counter) that corresponds to the current shot type
                    shotCounter[(int)shotType] += 1; // <-- I'm casting the enum value to an int to get the match

                    // Print the shot type
                    Console.ForegroundColor = ShotTypeColor[(int)shotType]; // <-- I'm explicitely casting the shotType to its integer value in order to get the corresponding ConsoleColor, as intialized in the ShotTypeColor field array
                    Console.Write(shotType);                                // <-- Print the name of the enum value
                    Console.Write(" shot.\n");
                }

                // Print statistics of all the shots fired
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                // Loop through all shot types
                for (int i = 0; i < Enum.GetNames(typeof(TypeOfShotEnum)).Length; i++)
                {
                    // Print the number of shots fired by this type and the total percentage of that type
                    Console.WriteLine($"Number of {(TypeOfShotEnum)i} shots fired: {shotCounter[i]} ({shotCounter[i] / (double)numberOfShotsFired:0%})"); // <-- I'm using string formatting syntax (:0%) to get the result of the expression represented as an percentage
                }

                // Wait for the user to aknowledge, before the next iteration of the loop
                Console.ReadKey(true);
            }
        }
    }
}