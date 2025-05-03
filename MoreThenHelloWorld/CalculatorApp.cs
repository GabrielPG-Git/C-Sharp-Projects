using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreThenHelloWorld
{
    public class CalculatorApp
    {
        // This class contains methods for basic arithmetic operations: addition, subtraction, multiplication, and division.
        // It also includes methods for handling multiple inputs for each operation.
        // The methods are private, meaning they can only be accessed within this class.
        // The methods are overloaded to handle both two inputs and multiple inputs.
        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Subtract(double a, double b)
        {
            return a - b;
        }
        private double Multiply(double a, double b)
        {
            return a * b;
        }
        private double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
        private double Add(params double[] n)
        {
            double sum = 0;
            foreach (int i in n)
            {
                sum += i;
            }
            return sum;
        }
        private double Subtract(params double[] n)
        {
            double result = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                result -= n[i];
            }
            return result;
        }
        
        private double Multiply(params double[] n)
        {
            double result = 1;
            foreach (double i in n)
            {
                result *= i;
            }
            return result;
        }
        private double Divide(params double[] n)
        {
            if (n.Length == 0 || n[0] == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double result = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                result /= n[i];
            }
            return result;
        }
        public void CalculatorMainMenu()
        {
            // It uses a while loop to keep the menu active until the user chooses to exit.
            while (true)
            {
                // Displays the calculator app menu and handles user input for various arithmetic operations.
                Console.WriteLine("Welcome to the Calculator App!");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Add Two Numbers");
                Console.WriteLine("2. Subtract Two Numbers");
                Console.WriteLine("3. Multiply Two Numbers");
                Console.WriteLine("4. Divide Two Numbers");
                Console.WriteLine("5. Add Multiple Numbers");
                Console.WriteLine("6. Subtract Multiple Numbers");
                Console.WriteLine("7. Multiply Multiple Numbers");
                Console.WriteLine("8. Divide Multiple Numbers");
                Console.WriteLine("9. Back to Main Menu");
                Console.WriteLine("Q. Exit");
                Console.Write("Enter your choice (1-9) or Q to Quit: ");
                // Get user input and store it as a string.
                // (??) provide a default value in case the input is null.
                string choice = Console.ReadLine() ?? string.Empty;

                // Compared the string for "q" or "Q" to allow for case-insensitive exit.
                if (choice == "q" || choice == "Q")
                {
                    // If the user enters "q" or "Q", exit app.
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }
                // If the user enters "9", clear the console and return to the main menu.
                // This is a recursive call.
                else if (choice == "9")
                {
                    ClearConsole();
                    new MainMenu().DisplayMenu();                    
                    break; 
                }
                // If the user enters "1" to "4", call the TwoInput method with the choice.
                else if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    ClearConsole();
                    TwoInput(choice);
                }
                // If the user enters "5" to "8", call the MultipleInput method with the choice.
                else if (choice == "5" || choice == "6" || choice == "7" || choice == "8")
                {
                    ClearConsole();
                    MultipleInput(choice);
                }
                // If the user enters an invalid choice, display an error message and continue the loop.
                else
                {
                    ClearConsole();
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
            }
        }
        // The TwoInput parameter is the choice the user picked.
        // It prompts the user for two numbers, performs the selected operation, and displays the result.
        private void TwoInput(string choice)
        {            
            try
            {
                
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {Add(num1, num2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {Subtract(num1, num2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {Multiply(num1, num2)}");
                        break;
                    case "4":
                        Console.WriteLine($"Result: {Divide(num1, num2)}");
                        break;
                }                
                Console.WriteLine("Input any key to continue...");
                Console.ReadKey();
                ClearConsole();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // The MultipleInput parameter is the choice the user picked.
        // It prompts the user for multiple numbers, performs the selected operation, and displays the result.
        private void MultipleInput(string choice)
        {
            try
            {
                Console.Write("Enter the numbers separated by spaces: ");
                string input = Console.ReadLine() ?? string.Empty;
                double[] numbers = input.Split(' ').Select(double.Parse).ToArray();

                switch (choice)
                {
                    case "5":
                        Console.WriteLine($"Result: {Add(numbers)}");
                        break;
                    case "6":
                        Console.WriteLine($"Result: {Subtract(numbers)}");
                        break;
                    case "7":
                        Console.WriteLine($"Result: {Multiply(numbers)}");
                        break;
                    case "8":
                        Console.WriteLine($"Result: {Divide(numbers)}");
                        break;
                }                                                
                
                Console.WriteLine("Input any key to continue...");
                Console.ReadKey();
                ClearConsole();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
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