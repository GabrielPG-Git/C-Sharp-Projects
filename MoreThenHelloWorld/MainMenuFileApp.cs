namespace MoreThenHelloWorld 
{
    public class MainMenuFileApp
    {
        public void Menu()
        {
            // Output a welcome message and the main menu options.
            Console.WriteLine("Welcome to the File Menu!");
            Console.WriteLine("1. Create a file");
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
                    // Call the CreateFile method to create a file.
                    // This method is a placeholder for file creation logic.
                    CreateFile();               
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
                    Menu();
                    break;
            }
        }
        private static void CreateFile()
        {
            var fileTools = new FileTools();
            // Call the CreateFile method to create a file.
            Console.WriteLine("File types Options:");
            Console.WriteLine("1. txt");
            Console.WriteLine("2. rtf");
            Console.WriteLine("3. docx");
            Console.WriteLine("If you want to create a file without file type, just press enter.");
            Console.Write("Enter the file type:");
            string fileType = Console.ReadLine() ?? string.Empty;
            if (fileType == "1" || fileType == "txt" || fileType == ".txt")
            {
                fileType = "txt";
            }
            else if (fileType == "2" || fileType == "rtf" || fileType == ".rtf")
            {
                fileType = "rtf";
            }
            else if (fileType == "3" || fileType == "docx" || fileType == ".docx")
            {
                fileType = "docx";
            }
            else
            {
                fileType = string.Empty;
            }            
            Console.Write("Enter the file name():");
            string fileName = Console.ReadLine() ?? string.Empty;
            if (fileName == string.Empty || fileName == "")
            {
                fileName = "NewFile";
            }
            if (fileType != string.Empty || fileType != "")
            {
                fileName = fileName + "." + fileType;
            }
            Console.Write("Enter the file path(Documents is defulte):");
            string filePath = Console.ReadLine() ?? string.Empty;

            if (filePath == string.Empty || filePath == "")
            {
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            fileTools.CreateFile(fileName, filePath);
            Console.WriteLine("Creating a file...");
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