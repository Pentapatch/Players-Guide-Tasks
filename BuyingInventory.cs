namespace Players_Guide_Tasks
{
    internal static class BuyingInventory
    {
        internal static void Run()
        {
            // Challenge: Buying inventory (100XP)

            // Stay inside a loop indefinitely
            while (true)
            {
                Console.Clear();

                // Create a dictionary of the items for sale, and assign members to it
                // The key is the index, the tuple contains the name of the item and it's price
                Dictionary<int, (string, int)> items = new() {
                    { 1, ("Rope", 10)},
                    { 2, ("Torches", 15)},
                    { 3, ("Climbing equipment", 25) },
                    { 4, ("Clean water", 1) },
                    { 5, ("Machete", 20) },
                    { 6, ("Canoe", 200) },
                    { 7, ("Food supplies", 1) },
                };

                // Print the list of items to the customer
                Console.WriteLine("The following items are available:");

                // Use a for loop to print all of the members contained within the dictionary
                for (int i = 1; i <= items.Count; i++)
                {
                    // Try to retrieve the a tuple from the dictionary, using the current index as the key
                    items.TryGetValue(i, out (string Name, int Price) currentItem);

                    // Print the result to the console (if successfull)
                    // - If the variable Name is null, the TryGetValue() method failed to find the tuple
                    if (currentItem.Name != null) Console.WriteLine($"{i} - {currentItem.Name}");
                }

                // Ask the user to enter the desired product number, then store that in a variable
                Console.Write("Enter the number of the product that you want to see the price of: ");
                int selectedProductIndex = Convert.ToInt32(Console.ReadLine());

                // Retrieve the result from the dictionary and print it to the user
                items.TryGetValue(selectedProductIndex, out (string Name, int Price) selectedItem);

                if (selectedItem.Name != null) // <-- same tactic here as in the for loop
                    Console.WriteLine($"{selectedItem.Name} costs {selectedItem.Price} gold.");
                else
                    Console.WriteLine("The specified item does not excist.");

                // Wait for the user to aknowledge before the next iteration of the loop
                Console.ReadKey(true);
            }
        }
    }
}