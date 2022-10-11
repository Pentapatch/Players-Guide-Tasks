using System.Drawing; // <-- Needed for the use of the Point class

namespace Players_Guide_Tasks
{
    internal static class TheDefenseOfConsolas
    {
        internal static void Run()
        {
            // Challenge: The defense of Consolas (200XP)
            Console.Title = "Defense of Consolas";

            // Stay inside a loop indefinitely
            while (true)
            {
                Console.Clear();

                // Ask the user to enter the X-coordinate of the anticipated attack, then store the answer in a variable
                Console.WriteLine("What is the X-coordinate of the anticipated attack?");
                int attackX = Convert.ToInt32(Console.ReadLine());

                // Ask the user to enter the Y-coordinate of the anticipated attack, then store the answer in a variable
                Console.WriteLine("What is the Y-coordinate of the anticipated attack?");
                int attackY = Convert.ToInt32(Console.ReadLine());

                // Calculate the four positions that is needed in order to protect the city tile
                Point positionAbove = new(attackX, attackY - 1);
                Point positionBelow = new(attackX, attackY + 1);
                Point positionLeft = new(attackX - 1, attackY);
                Point positionRight = new(attackX + 1, attackY);

                // Clear the console
                Console.Clear();

                // Use two For loops to display a 8x8 grid system in the console
                for (int Y = -1; Y < 8; Y++) // Begins at -1 in order to print the column grid number
                {
                    for (int X = 0; X < 8; X++)
                    {
                        // Reset the foreground color
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        // If the current X-value is 0, print out the current column number of the Y-axis
                        if (X == 0) Console.Write($"{Y + 1} ");

                        // Check if we are on the initialization stage of the Y-loop (-1)
                        if (Y != -1)
                        { // Is Not initializing
                            // Change the color to Red if the current place in the loops correspond to the attack site
                            if (X + 1 == attackX && Y + 1 == attackY) Console.ForegroundColor = ConsoleColor.Red;

                            // Change the color to Yellow if the current place in the loops correspond to any of the four defensive positions
                            bool isDefensivePosition = true;
                            if (X + 1 == positionAbove.X && Y + 1 == positionAbove.Y) { }
                            else if (X + 1 == positionBelow.X && Y + 1 == positionBelow.Y) { }
                            else if (X + 1 == positionLeft.X && Y + 1 == positionLeft.Y) { }
                            else if (X + 1 == positionRight.X && Y + 1 == positionRight.Y) { }
                            else { isDefensivePosition = false; }
                            if (isDefensivePosition) Console.ForegroundColor = ConsoleColor.Green;

                            // Write a grid marker
                            Console.Write("X ");
                        }
                        else
                        {
                            // Is initializing: print out the numbering system on the X-axis
                            Console.Write($"{X + 1} ");
                        }
                    }
                    Console.Write("\n"); // Add a new line
                }

                // Print out location information to the user
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Anticipated attack @ ({attackX}, {attackY})");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Defender Above     @ ({positionAbove.X}, {positionAbove.Y})");
                Console.WriteLine($"Defender Below     @ ({positionBelow.X}, {positionBelow.Y})");
                Console.WriteLine($"Defender Left      @ ({positionLeft.X}, {positionLeft.Y})");
                Console.WriteLine($"Defender Right     @ ({positionRight.X}, {positionRight.Y})");

                // Beep, reset the foreground color then wait for the user to aknowledge
                Console.Beep(480, 200);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey(true);
            }
        }
    }
}