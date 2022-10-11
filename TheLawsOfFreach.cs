namespace Players_Guide_Tasks
{
    internal static class TheLawsOfFreach
    {
        internal static void Run()
        {
            // Challenge: The laws of Freach (50XP)

            // Declare and initialize an array with some integers
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            // Find the smallest value in the array
            int currentSmallest = int.MaxValue; // Give it an initial value that is the highest possible
            int total = 0;
            foreach (int currentInteger in array)
            {
                if (currentInteger < currentSmallest)
                    currentSmallest = currentInteger;

                total += currentInteger;
            }

            // Calculate the avarage value based on the sum of the array and the length of the array
            float avarage = (float)total / array.Length;

            Console.WriteLine($"The smallest value of the array is: {currentSmallest}");
            Console.WriteLine($"The avarage value of the array is: {avarage}");
            Console.ReadKey(true);
        }
    }
}