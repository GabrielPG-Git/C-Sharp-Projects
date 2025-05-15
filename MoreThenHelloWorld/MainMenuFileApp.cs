namespace MoreThenHelloWorld 
{
    public class MainMenuFileApp
    {
        public void Menu()
        {
            bool bRunning = true;
            while (bRunning)
            {
                // Call the DisplayMenu method to show the menu.
                bRunning = DisplayMenu();
            }
        }
        private bool DisplayMenu()
        {
            //Setting up variables
            string userInput;

            // Output a welcome message and the main menu options.
            Console.WriteLine("Welcome to the File App!");
            Console.WriteLine("1. Create File");
            //Console.WriteLine("2. Read File");
            //Console.WriteLine("3. Write File");
            //Console.WriteLine("4. Delete File");
            //Console.WriteLine("5. Open File");
            //Console.WriteLine("6. Save File");
            //Console.WriteLine("7. Close File");
            //Console.WriteLine("8. Edit File");
            //Console.WriteLine("9. Search File");
            //Console.WriteLine("10. Replace File");
            //Console.WriteLine("11. Print File");
            //Console.WriteLine("12. Print File Content");
            //Console.WriteLine("13. Print File Name");
            //Console.WriteLine("14. Print File Path");
            //Console.WriteLine("15. Print File Size");
            //Console.WriteLine("16. Print File Type");
            //Console.WriteLine("17. Print File Date");
            Console.WriteLine("Q. Exit");
            Console.Write("Please select an option: ");
            // Get user input and store it as a string.
            // provide a default value in case the input is null.
            userInput = Console.ReadLine() ?? string.Empty;

            switch (userInput.ToUpper())
            {
                case "1":
                    // Call the CreateFile method to create a file.
                    CreateFile();
                    break;
                case "Q":
                    // print Goodbye! and exit the application.
                    Console.WriteLine("Exiting the application. Goodbye!");
                    return false;
                default:
                    // This line clears the console screen.
                    ClearConsole();
                    // Display an error message.
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
            return true;
        }
        // It prompts the user for file type, name, and path, and then creates a file.
        private static void CreateFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileName;
            string fileType;
            string filePath;

            ClearConsole();
            // Output a welcome message and the file creation options.
            Console.WriteLine("Welcome to the File Creation App!\n");
            Console.WriteLine("***** File types *****");
            Console.WriteLine("1. txt(defult)");
            Console.WriteLine("2. rtf");
            Console.WriteLine("3. docx");
            Console.WriteLine("4. xlsx");
            Console.Write("Enter the file type: ");
            fileType = Console.ReadLine() ?? string.Empty;

            // Check and set the file extension.
            if (fileType == "2")
            {
                fileType = "rtf";
            }
            else if (fileType == "3")
            {
                fileType = "docx";
            }
            else if (fileType == "4")
            {
                fileType = "xlsx";
            }
            else
            {
                fileType = "txt";
            }

            ClearConsole();
            // ask the user for the file name.
            Console.WriteLine("***** File name *****");
            Console.Write("Enter the file name: ");
            fileName = Console.ReadLine() ?? string.Empty;
            fileName = fileName + "." + fileType;

            ClearConsole();
            // ask the user for the file path.
            Console.WriteLine("***** File path *****");
            Console.WriteLine("just press enter for default path");
            Console.WriteLine("Default path is: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.Write("Enter the file path: ");
            filePath = Console.ReadLine() ?? string.Empty;

            // Check and set the file path.
            if (filePath == string.Empty || filePath == "")
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            ClearConsole();
            // Create a file.
            Console.WriteLine("Creating a file...");
            fileTools.CreateFile(fileName, filePath);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public static void ClearConsole()
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