namespace MoreThenHelloWorld
{
    public class FileTools : IFileTools
    {
        public void CreateFile(string fileName, string filePath)
        {
            // Create a file with the specified name and path.
            // If the file already exists, overwrite it.
            // If the file does not exist, create a new file.
            try
            {
                // Check if the file path exists, if not create it.
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Console.WriteLine($"Directory {filePath} created.");
                }
                string fullPath = Path.Combine(filePath, fileName);
                using (var stream = File.Create(fullPath))
                {
                    Console.WriteLine($"File {fileName} created at {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating file: {ex.Message}");
            }
            
        }
    }
}