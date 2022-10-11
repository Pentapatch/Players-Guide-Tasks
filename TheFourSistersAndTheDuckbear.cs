namespace Players_Guide_Tasks
{
    internal static class TheFourSistersAndTheDuckbear
    {
        internal static void Run()
        {
            // ## Challenge: The four sisters and the duckbear (100XP)
            // Fråga: Vilka tre scenarion ger duckbear fler ägg än systrarna?
            // Svar:  1, 2, 3 men också 6, 7, 11

            // Stay inside a loop indefinitely
            while (true)
            {
                Console.Clear();

                // Set the number of persons that will split the eggs
                int numberOfPersons = 4;

                // Ask the user to input how many eggs was collected today, and store the result in a variable
                Console.WriteLine("How many eggs was collected today?");
                int numberOfEggs = Convert.ToInt32(Console.ReadLine());

                // Calculate the remainder
                int remainder = numberOfEggs % numberOfPersons;     // <-- using the modulus operator %
                int eggsPerPerson = numberOfEggs / numberOfPersons; // <-- note: integer division operator

                // Produce a result string
                string pluralExtensionDuckbear = remainder > 1 ? "s" : string.Empty; //    Add an 's' character after "egg" to signify plurality
                string pluralExtensionSisters = eggsPerPerson > 1 ? "s" : string.Empty; // Add an 's' character after "egg" to signify plurality
                string resultString = eggsPerPerson == 0 ? "The sisters get no eggs." : $"Each sister gets {eggsPerPerson} egg{pluralExtensionSisters}.";
                resultString += remainder == 0 ? " Do not feed duckbear any eggs." : $" Give duckbear {remainder} egg{pluralExtensionDuckbear}.";

                // Print the result to the user
                Console.WriteLine(resultString);
                Console.ReadKey(true); // wait for aknowledgement
            }
        }
    }
}