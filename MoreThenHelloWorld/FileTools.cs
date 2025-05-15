namespace MoreThenHelloWorld
{
    public class FileTools : IFileTools
    {
        public void CreateFile(string fileName, string filePath)
        {
            // Create a file with the specified name and path.
            try
            {
                // Check if the file path exists, if not create it.
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Console.WriteLine($"Directory {filePath} created.",Console.ForegroundColor = ConsoleColor.DarkGreen);
                }
                string fullPath = Path.Combine(filePath, fileName);
                // Check if the file already exists.
                if (File.Exists(fullPath))
                {
                    Console.WriteLine($"{fileName} already exists.",Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Create the file.
                // The using statement ensures that the file is properly closed and disposed of after use.
                using (var stream = File.Create(fullPath))
                {
                    Console.WriteLine($"File created at {filePath}\\{fileName}", Console.ForegroundColor = ConsoleColor.Green);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when creating the file: {ex.Message}");
            }
            
        }
    }
}