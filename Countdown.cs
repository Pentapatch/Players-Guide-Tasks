namespace Players_Guide_Tasks
{
    internal static class Countdown
    {
        internal static void Run()
        {
            // Challenge: Countdown (100XP)

            // Call the method only once
            CountDownFromTen();

            // Wait for the user to aknowledge
            Console.ReadKey(true);
        }

        private static void CountDownFromTen(int current = 10) // Note: using an optional parameter so we don't have to pass one in when first calling this method
        {
            // Write the current value to the console
            Console.WriteLine(current);

            if (current > 1) // Base case is when current <= 1
                CountDownFromTen(current - 1); // Call this method recursively
        }
    }
}