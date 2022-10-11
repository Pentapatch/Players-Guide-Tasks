using System.Drawing; // <-- Needed for the use of the Point class

namespace Players_Guide_Tasks
{
    internal static class Watchtower
    {
        internal static void Run()
        {
            // Challenge: Watchtower (100XP)

            // Stay in a loop indefinitely
            while (true)
            {
                Console.Clear();

                // Ask the user for the X-coordinate of the enemy, then store it in a variable
                Console.Write("Enter the X-coordinate of the enemy: ");
                int enemyPositionX = Convert.ToInt32(Console.ReadLine());

                // Ask the user for the Y-coordinate of the enemy, then store it in a variable
                Console.Write("Enter the Y-coordinate of the enemy: ");
                int enemyPositionY = Convert.ToInt32(Console.ReadLine());

                // Declare and assign a Point that holds the enemy's position
                Point enemyPosition = new(enemyPositionX, enemyPositionY);

                // Select the string to display to the user
                string enemyDirectionString = enemyPosition.Y < 0 ? "south" : enemyPosition.Y > 0 ? "north" : "";
                enemyDirectionString += enemyPosition.X < 0 ? "west" : enemyPosition.X > 0 ? "east" : "";
                enemyDirectionString = enemyDirectionString + (enemyDirectionString != "" ? " of " : "") + "here!";

                // Note: If the line above is hard to understand - consider:
                //if (enemyDirectionString == "")
                //    enemyDirectionString = "here!";
                //else
                //    enemyDirectionString += " of here!";

                // Another way (more lines but easier to read) to do it would be:

                // Calculate the cardinal direction of the enemy relative to the watchtower
                //string cardinalDirection = string.Empty;
                //if (enemyPosition.Y < 0)
                //    cardinalDirection = "S";
                //else if (enemyPosition.Y > 0)
                //    cardinalDirection = "N";
                //if (enemyPosition.X < 0)
                //    cardinalDirection += "W";
                //else if (enemyPosition.X > 0)
                //    cardinalDirection += "E";

                //// Select what string to display based on the cardinal direction
                //string resultString = cardinalDirection switch
                //{
                //    "NW" => "northwest",
                //    "W" => "west",
                //    "SW" => "southwest",
                //    "N" => "north",
                //    "S" => "south",
                //    "NE" => "northeast",
                //    "E" => "east",
                //    "SE" => "southeast",
                //    _ => "here"
                //};

                // Print the result to the user
                Console.WriteLine($"The enemy is {enemyDirectionString}");
                Console.ReadKey(true);
            }
        }
    }
}