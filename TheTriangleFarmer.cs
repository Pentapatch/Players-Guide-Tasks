namespace Players_Guide_Tasks
{
    internal static class TheTriangleFarmer
    {
        internal static void Run()
        {
            // ## Challenge: The triangle farmer (100XP)

            // Ask the user to input the base of the triangle, and store the result in a variable
            Console.WriteLine("How wide is the triangle at the base? (in centimeters)");
            int baseVal = Convert.ToInt32(Console.ReadLine());

            // Ask the user to input the height of the triangle, and store the result in a variable
            Console.WriteLine("How high is the triangle? (in centimeters)");
            int heightVal = Convert.ToInt32(Console.ReadLine());

            // Calculate the area and put the result in a variable, then display it to the user
            double area = (baseVal * heightVal / (double)2); // Note that I'm casting the literal 2 to a double, in order to make the division operator using double division
                                                             // Another way to do it would be replacing it with 2D - using the double suffix

            // Print the result to the user
            Console.WriteLine($"The area of the triangle is {area}cm2.");
            Console.ReadKey();
        }
    }
}