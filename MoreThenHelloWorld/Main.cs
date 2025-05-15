namespace MoreThenHelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This is a simple prints "Hello World!".
            // It demonstrates the use of a string variable and the Console.WriteLine method.
            const string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld);

            // Console input and output request.
            Console.WriteLine("Enter Q to quit or any other key to continue...");

            // Get a user input and store it as a string.
            // (??) provide a default value in case the input is null.
            string userInput = Console.ReadLine() ?? string.Empty;

            // Compare the user input with the string "Q/q".
            if (userInput == "Q"|| userInput =="q")
            {
                // Print Goodbye!
                // It also uses the return statement to exit the Main method and terminate the program.
                Console.WriteLine("Goodbye!");
                return;
            }
                        
            // Try to clear the console screen.
            try
            {
                Console.Clear();
            }
            catch (Exception ex)
            {
                // If an exception occurs prints the exception message.
                Console.WriteLine($"Error clearing console: {ex.Message}");
            }

            // Creates an instance of the MainMenu class and calls its DisplayMenu method.
            var menu = new MainMenu();
            // Displaying the main menu.
            menu.DisplayMenu();
            
        }
    }
}