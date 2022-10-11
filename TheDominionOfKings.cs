namespace Players_Guide_Tasks
{
    internal static class TheDominionOfKings
    {
        internal static void Run()
        {
            // Challenge: The dominion of kings (100XP)

            // Stay inside a loop indefinitely
            while (true)
            {
                Console.Clear();

                // Ask the user how many provinces they rule, store the result in a variable
                Console.WriteLine("How many provinces do you rule?");
                int provinceCount = Convert.ToInt32(Console.ReadLine());

                // Ask the user how many duchies they rule, store the result in a variable
                Console.WriteLine("How many duchies do you rule?");
                int duchieCount = Convert.ToInt32(Console.ReadLine());

                // Ask the user how many estates they rule, store the result in a variable
                Console.WriteLine("How many estates do you rule?");
                int estateCount = Convert.ToInt32(Console.ReadLine());

                // Calculate the points for each of the categories
                int provincePoints = provinceCount * 6;
                int duchiePoints = duchieCount * 3;
                int estatePoints = estateCount; // Estates are worth 1 point each, so we can omit the multiplication
                int totalPoints = provincePoints + duchiePoints + estatePoints;

                // Clear the console then display a summary and the result points
                Console.Clear();
                Console.WriteLine($"You own {provinceCount} province(s) which nets you {provincePoints} points.");
                Console.WriteLine($"You own {duchieCount} duchie(s) which nets you {duchiePoints} points.");
                Console.WriteLine($"You own {estateCount} estate(s) which nets you {estatePoints} points.");
                Console.WriteLine($"Your total points is: {totalPoints}.");

                Console.ReadKey(); // Wait for the user to aknowledge before the next iteration of the loop
            }
        }
    }
}