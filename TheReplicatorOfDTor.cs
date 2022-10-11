namespace Players_Guide_Tasks
{
    internal static class TheReplicatorOfDTor
    {
        internal static void Run()
        {
            // Challenge: The replicator of D'Tor (100XP)

            // Get five number inputs from the user
            int[] answers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}/5 Enter any integer number: ");
                answers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Disclaimer: Normally i would have copied the value directly in the above loop, or used answers.CopyTo()
            int[] copiedAnswers = new int[answers.Length];
            for (int i = 0; i < 5; i++)
            {
                copiedAnswers[i] = answers[i];
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Here comes the copied values:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}) Original value: {answers[i]} Copied value: {copiedAnswers[i]}");
            }

            Console.ReadKey(true);

            // ########################
            // ## Refactored version ##
            // ########################

            //int arrayLength = 5;
            //int[] answers = new int[arrayLength];
            //int[] copiedAnswers = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write($"{i + 1}/5 Enter any integer number: ");
            //    answers[i] = Convert.ToInt32(Console.ReadLine());
            //    copiedAnswers[i] = answers[i];
            //}

            //Console.Clear();
            //Console.WriteLine("Here comes the copied values:");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}) Original value: {answers[i]} Copied value: {copiedAnswers[i]}");
            //}

            //Console.ReadKey(true);
        }
    }
}