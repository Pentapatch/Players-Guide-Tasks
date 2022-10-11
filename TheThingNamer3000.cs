namespace Players_Guide_Tasks
{
    internal static class TheThingNamer3000
    {
        internal static void Run()
        {
            // ## Challenge: The thing namer 3000 (100XP)
            // Fråga: Vad skulle du mer göra för att göra programmet mer förståeligt?
            // Svar:  Hade givit variablerna bättre namn, använt string interpolation i svaret, placerat kommentarerna över raderna istället.

            Console.WriteLine("What kind of thing are we talking about?");
            string? a = Console.ReadLine(); // Stores the "type of thing to be named"
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string? b = Console.ReadLine(); // Stores the "description of the thing to be named"
            string c = "Doom"; // "Bug" was here, "of" is also added in the final printout
            string d = "3000";
            Console.WriteLine("The " + b + /* + the description of the object to be named */ " " + a /* The object to be named */ + " of " + c /* Hardcoded extra info ("Doom")*/ + " " + d /* Hardcoded extra info ("3000") */ + "!");
            Console.ReadLine();

            // ####################
            // ## Bättre version ##
            // ####################

            // Set up hardcoded object naming properties
            string objectClass = "Doom";
            string objectVersion = "3000";

            // Ask the user for the name (type) of the object and store it in a variable
            Console.WriteLine("What kind of thing are we talking about?");
            string? objectName = Console.ReadLine(); // <-- making objectName nullable by using the ? operator, just to get rid of the compiler warning

            // Ask the user to describe the object and store that in a variable
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string? objectDescription = Console.ReadLine();

            // Print the result to the user
            Console.Clear();
            Console.WriteLine($"It should be called: The {objectDescription} {objectName} of {objectClass} {objectVersion}");
            Console.ReadKey(); // Wait for the user to aknowledge by pressing any key, before exiting the app
        }
    }
}