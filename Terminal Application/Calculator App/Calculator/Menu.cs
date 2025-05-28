namespace Calculator
{
    public class Menu
    {
        
            // The start of a loop and the main menu of the calculator
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Please select an option: ");

                string sChoice = Console.ReadLine() ?? string.Empty;
                Math math = new(0, 0);

                switch (sChoice)
                {
                    case "1":
                        // Call Add method
                        Console.Clear();
                        DisplayRequestForInput(math, "Addition");
                        break;
                    case "2":
                        // Call Subtract method
                        Console.Clear();
                        DisplayRequestForInput(math, "Subtraction");
                        break;
                    case "3":
                        // Call Multiply method
                        Console.Clear();
                        DisplayRequestForInput(math, "Multiplication");
                        break;
                    case "4":
                        // Call Divide method
                        Console.Clear();
                        DisplayRequestForInput(math, "Division");
                        break;
                    case "5":
                        return; // Exit the menu
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        // Methods to handle user first input
        public static bool TryMeNum1(Math math)
        {
            try
            {
                math.dNum1 = Convert.ToDouble(Console.ReadLine());
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        // Methods to handle user second input and check for division by zero
        public static bool TryMeNum2(Math math, string operation)
        {
            try
            {
                math.dNum2 = Convert.ToDouble(Console.ReadLine());
                if (operation.ToLower() == "division" && math.dNum2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    Console.Write("Enter any key to continue...");
                    math.dNum1 = 0;
                    math.dNum2 = 0;
                    Console.ReadKey();
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        // Method to display the request for input and perform the operation
        public static void DisplayRequestForInput(Math math, string operation)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(operation + " Operation");
                Console.WriteLine("-------------------");
                if (math.dNum1 == 0 && math.dNum2 == 0)
                {
                    Console.Write("Enter first number: ");
                    if (!TryMeNum1(math)) continue;

                    Console.Write("Enter second number: ");
                    if (!TryMeNum2(math, operation)) continue;
                }
                else
                {
                    Console.WriteLine($"Last Result: {math.dLastResult}");
                    Console.Write("Do you want to use the last result? (y/n) or (e) to Exit: ");
                    string useLastResult = Console.ReadLine()?.ToLower() ?? string.Empty;
                    if (useLastResult == "e")
                    {
                        break; // Exit the loop
                    }
                    else if (useLastResult != "y" && useLastResult != "n")
                    {
                        continue;
                    }
                    if (useLastResult == "y")
                    {
                        math.dNum1 = math.dLastResult;
                        Console.Write("Enter second number: ");
                        if (!TryMeNum2(math, operation)) continue;
                    }
                    else
                    {
                        Console.Write("Enter first number: ");
                        if (!TryMeNum1(math)) continue;
                        Console.Write("Enter second number: ");
                        if (!TryMeNum2(math, operation)) continue;
                    }
                }
                try
                {
                    math.dLastResult = operation.ToLower() switch
                    {
                        "addition" => math.Add(),
                        "subtraction" => math.Subtract(),
                        "multiplication" => math.Multiply(),
                        "division" => math.Divide(),
                        _ => throw new InvalidOperationException("Invalid operation specified."),
                    };
                    Console.WriteLine($"Result: {math.dLastResult}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}