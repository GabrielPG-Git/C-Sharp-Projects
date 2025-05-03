using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreThenHelloWorld
{
    public class MainMenu
    {
        public void DisplayMenu()
        {
            // Output a welcome message and the main menu options.
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("1. Calculator App");
            Console.WriteLine("2. File place holder");
            Console.WriteLine("3. Network place holder");
            Console.WriteLine("4. Game place holder");
            Console.WriteLine("Q. Exit");
            Console.Write("Please select an option: ");
            // Get user input and store it as a string.
            // provide a default value in case the input is null.
            string userInput = Console.ReadLine() ?? string.Empty;
            
            switch (userInput.ToUpper())
            {
                case "1":
                    // This line clears the console screen.
                    ClearConsole();                    
                    // Create an instance of the CalculatorApp class and call its method to start the calculator app.
                    var calculatorApp = new CalculatorApp();
                    // Displaying the CalculatorApp.
                    calculatorApp.CalculatorMainMenu();
                    break;
                case "Q":
                    // print Goodbye! and exit the application.
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    // This line clears the console screen.
                    ClearConsole();
                    // Display an error message.
                    Console.WriteLine("Invalid selection. Please try again.");
                    // Call the DisplayMenu method again to show the menu.
                    // This is a recursive call.
                    DisplayMenu();
                    break;
            }
        }
        private void ClearConsole()
        {
            // Try to clear the console screen.
            // If an exception occurs, catch it and print the exception message.
            try
            {
                Console.Clear();
            }
            catch (Exception ex)
            {   
                Console.WriteLine($"Error clearing console: {ex.Message}");
            }
        }
        
    }
}