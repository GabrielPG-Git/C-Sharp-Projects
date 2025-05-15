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
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Write File");
            Console.WriteLine("4. Append to File");
            Console.WriteLine("5. Edit File");
            Console.WriteLine("6. Delete File");
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
                case "2":
                    // Call the ReadFile method to read a file.
                    // This method is a placeholder for file reading logic.
                    ReadFile();
                    break;
                case "3":
                    // Call the WriteFile method to write a file.
                    // This method is a placeholder for file writing logic.
                    WriteFile();
                    break;
                case "4":
                    // Call the AppendFile method to append to a file.
                    // This method is a placeholder for file appending logic.
                    AppendFile();
                    break;
                case "5":
                    // Call the EditFile method to edit a file.
                    // This method is a placeholder for file editing logic.
                    EditFile();
                    break;
                case "6":
                    // Call the DeleteFile method to delete a file.
                    // This method is a placeholder for file deletion logic.
                    DeleteFile();
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
        // It prompts the user for a file location and then reads the file.
        private static void ReadFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileLocation;

            ClearConsole();
            // Output a welcome message and the file reading options.
            Console.WriteLine("Welcome to the File Reading App!\n");
            Console.WriteLine("***** File location *****");
            Console.Write("Enter the file location: ");
            fileLocation = Console.ReadLine() ?? string.Empty;

            // Read a file.
            Console.WriteLine("Reading a file...");
            fileTools.ReadFile(fileLocation);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public void WriteFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileLocation;
            string fileContent;

            ClearConsole();
            // Output a welcome message and the file writing options.
            Console.WriteLine("Welcome to the File Writing App!\n");
            Console.WriteLine("***** File location *****");
            Console.Write("Enter the file location: ");
            fileLocation = Console.ReadLine() ?? string.Empty;

            // ask the user for the file content.
            Console.WriteLine("***** File content *****");
            Console.Write("Enter the file content: ");
            fileContent = Console.ReadLine() ?? string.Empty;

            // Write a file.
            Console.WriteLine("Writing a file...");
            fileTools.WriteFile(fileLocation, fileContent);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public static void EditFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileLocation;
            string TextObject;
            string newValue;

            ClearConsole();
            // Output a welcome message and the file editing options.
            Console.WriteLine("Welcome to the Sellected Text Editing App!\n");
            Console.WriteLine("***** File location *****");
            Console.Write("Enter the file location: ");
            fileLocation = Console.ReadLine() ?? string.Empty;

            // ask the user for the file content.
            Console.WriteLine("***** File content *****");
            Console.Write("Enter the selected text: ");
            TextObject = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter the new value: ");
            newValue = Console.ReadLine() ?? string.Empty;

            // Edit a file.
            Console.WriteLine("Editing a file...");
            fileTools.EditTextValueOfAFile(fileLocation, TextObject,newValue);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public static void DeleteFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileLocation;

            ClearConsole();
            // Output a welcome message and the file deletion options.
            Console.WriteLine("Welcome to the File Deletion App!\n");
            Console.WriteLine("***** File location *****");
            Console.Write("Enter the file location: ");
            fileLocation = Console.ReadLine() ?? string.Empty;

            // Delete a file.
            Console.WriteLine("Deleting a file...");
            fileTools.DeleteFile(fileLocation);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public static void AppendFile()
        {
            // Setting up variables
            var fileTools = new FileTools();
            string fileLocation;
            string fileContent;

            ClearConsole();
            // Output a welcome message and the file appending options.
            Console.WriteLine("Welcome to the File Appending App!\n");
            Console.WriteLine("***** File location *****");
            Console.Write("Enter the file location: ");
            fileLocation = Console.ReadLine() ?? string.Empty;

            // ask the user for the file content.
            Console.WriteLine("***** File content *****");
            Console.Write("Enter the file content: ");
            fileContent = "\n" + Console.ReadLine() ?? string.Empty;

            // Append to a file.
            Console.WriteLine("Appending to a file...");
            fileTools.AppendToFile(fileLocation, fileContent);
            Console.WriteLine("\n", Console.ForegroundColor = ConsoleColor.White);
        }
        public static void TempFileLastAccess()
        {
            // file open temp file
            // display the last access time
            // output options 
            // close the file
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