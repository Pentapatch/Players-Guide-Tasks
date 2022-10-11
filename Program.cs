using System.Reflection;   // Used for retrieving all classes contained within this assembly
using System.Text.RegularExpressions; // Used for string formatting

bool wrapArround = true;

// Get a list of all classes that are contained within this namespace
List<Type> typesList = GetClassList();

// Stay in a loop indefinitely
int index = 0;
while (true)
{
    ClearConsole(); // Clear and restore the console

    // Enumerate all types in the list and print them to the console
    int count = 0;
    foreach (Type currentType in typesList)
    {
        // Set the color of the menu entry
        if (count == index)
            Console.BackgroundColor = ConsoleColor.Blue;
        else
            Console.BackgroundColor = ConsoleColor.Black;

        // Print the current class name to the console
        Console.WriteLine($"{count++}: {FormatClassName(currentType.Name)}");
    }

    // Wait for the user to press a key
    bool exitReadKeyLoop = false;
    while (!exitReadKeyLoop)
    {
        // Note: The reason I'm using a loop inside the main loop is to avoid a refresh of the content
        //       (next iteration of the main loop) when a key that was not expected was pressed.

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow:
                // Decrement the index of the currently selected menu item
                if (--index < 0)
                {
                    if (wrapArround)
                        index = typesList.Count - 1;
                    else
                        index = 0;
                }
                break;
            case ConsoleKey.DownArrow:
                // Increment the index of the currently selected menu item
                if (++index > typesList.Count - 1)
                {
                    if (wrapArround)
                        index = 0;
                    else
                        index = typesList.Count - 1;
                }
                break;
            case ConsoleKey.Enter:
                // Execute the selected task
                RunTask(typesList[index]);
                break;
            default:
                exitReadKeyLoop = true;
                break;
        }

        exitReadKeyLoop = !exitReadKeyLoop;
    }

}

static void ClearConsole()
{
    // Set up the console
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.CursorVisible = false;
    Console.Clear();
}

static List<Type> GetClassList()
{
    // Using reflection and query to get a list of all classes in the Players_Guide_Tasks assembly
    IEnumerable<Type> q = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.IsClass && t.Namespace == "Players_Guide_Tasks"
                          select t;

    // Convert the IEnumerable to a list
    List<Type> typesList = q.ToList();

    // Sort the list by the name of the class
    typesList.Sort((x, y) => x.Name.CompareTo(y.Name));

    // Return the list
    return typesList;
}

static void RunTask(Type type)
{
    // Using query to select all methods that is called "Run" inside of the type
    var methods = from q in type.GetRuntimeMethods()
                  where q.Name == "Run"
                  select q;

    // Make sure that the targeted method was found
    if (methods.ToArray().Length == 0)
    {
        ClearConsole();
        Console.WriteLine("Error: Could not find a method named 'Run' inside the class.");
        Console.ReadKey(true); // Wait for the user to aknowledge
        return; // Break out of the method
    }

    // Get the method info of the first object in the IEnumerable
    MethodInfo? method = methods.ToArray()[0];

    // Invoke the Run method
    if (method != null)
    {
        try
        {
            // Clear and restore the console
            ClearConsole();

            // Invoke the Run method
            method.Invoke(null, null);
        }
        catch (Exception e)
        {
            // Print the error to the user
            ClearConsole();
            Console.WriteLine("Error. Could not run this method...\n");
            Console.WriteLine($"Message: {e.Message}");
            Console.ReadKey(true); // Wait for the user to aknowledge
        }
    }

}

static string FormatClassName(string input)
{
    // Split all words that starts with upper case and insert a space character
    string result = Regex.Replace(input, "([A-Z])", " $1", RegexOptions.Compiled).Trim();

    // Make the first character upper case and the rest in lower case, then return the result
    return result[..1].ToUpper() + result[1..].ToLower();
}