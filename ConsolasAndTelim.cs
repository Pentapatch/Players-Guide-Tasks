namespace Players_Guide_Tasks
{
    internal static class ConsolasAndTelim
    {
        internal static void Run()
        {
            // ## Challenge: Consolas and Telim (50XP)
            Console.WriteLine("I am Telim. I got some bread ready for you!");
            Console.WriteLine("Who is the bread for?");
            string? userName = Console.ReadLine(); // <-- Using the nullable type modifer ? here just to get rid of the compiler warning
            Console.WriteLine($"Noted, here's some bread for {userName}."); // <-- Using string interpolation here with the $ prefix
            Console.ReadKey();
        }
    }
}