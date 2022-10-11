namespace Players_Guide_Tasks
{
    internal static class SimulasSoup
    {
        public enum TypeEnum
        {
            Soup = 0,
            Stew,
            Gumbo,
        }

        public enum MainIngredientEnum
        {
            Mushrooms = 0,
            Chicken,
            Carrot,
            Potato,
        }

        public enum SeasoningEnum
        {
            Spicy = 0,
            Salty,
            Sweet,
        }

        internal static void Run()
        {
            var dish = GetDish(); // Get the user selected dish

            // Print the result to the user
            Console.Clear();
            Console.WriteLine($"Mmmm... Time for {dish.Seasoning} {dish.MainIngredient} {dish.Type}!");
            
            // Wait for user aknowledgement, then exit the method
            Console.ReadKey(true);
        }

        private static (TypeEnum Type, MainIngredientEnum MainIngredient, SeasoningEnum Seasoning) GetDish()
        {
            // Ask the user to select the type, main ingredient and seasoning
            TypeEnum type = (TypeEnum)PrintMenu("Choose the type of dish:", new TypeEnum());
            MainIngredientEnum mainIngredient = (MainIngredientEnum)PrintMenu("Choose the main ingredient:", new MainIngredientEnum());
            SeasoningEnum seasoning = (SeasoningEnum)PrintMenu("Choose the seasoning:", new SeasoningEnum());

            // Return a tuple containing their answers
            return (type, mainIngredient, seasoning);
        }

        private static int PrintMenu(string message, Enum enumType) => PrintMenu(message, Enum.GetNames(enumType.GetType()));

        private static int PrintMenu(string message, params string[] menuItemName)
        {
            int index = 0;

            // Stay inside a loop indefinitely, or until the user presses return
            while (true)
            {
                // Set up the console
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                Console.Clear();

                // Print the message
                Console.WriteLine(message + "\nUse the up/down arrow keys to navigate the menu.\n");

                // Print all of the options
                for (int i = 0; i < menuItemName.Length; i++)
                {
                    // Set up the coloring
                    Console.ForegroundColor = i == index ? ConsoleColor.Black : ConsoleColor.White;
                    Console.BackgroundColor = i == index ? ConsoleColor.White : ConsoleColor.Black;

                    // Write the menu item
                    Console.WriteLine(menuItemName[i]);
                }

                // Wait for the user to press a key
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        return index; // Return the index of the currently selected option
                    default:
                        break;
                }

                // Check if we should wrap arround
                if (index < 0) index = menuItemName.Length - 1;
                if (index == menuItemName.Length) index = 0;
            }
        }
    }
}