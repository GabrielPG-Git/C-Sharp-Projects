namespace MoreThenHelloWorld
{
    public class FileTools
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
                    Console.WriteLine($"Directory {filePath} created.", Console.ForegroundColor = ConsoleColor.DarkGreen);
                }
                string fullPath = Path.Combine(filePath, fileName);
                // Check if the file already exists.
                if (File.Exists(fullPath))
                {
                    Console.WriteLine($"{fileName} already exists.", Console.ForegroundColor = ConsoleColor.Red);
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
        public void ReadFile(string fileLocation)
        {
            // Read the file at the specified location.
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Read the file content.
                string content = File.ReadAllText(fileLocation);
                Console.WriteLine($"File content: {content}", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when reading the file: {ex.Message}");
            }

        }
        public void WriteFile(string fileLocation, string fileContent)
        {
            // Write the specified content to the file at the specified location.
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Write the content to the file.
                File.WriteAllText(fileLocation, fileContent);
                Console.WriteLine($"File {fileLocation} written successfully.", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when writing to the file: {ex.Message}");
            }

        
        }
        public void AppendToFile(string fileLocation, string fileContent)
        {
            // Append the specified content to the file at the specified location.
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Append the content to the file.
                File.AppendAllText(fileLocation, fileContent);
                Console.WriteLine($"File {fileLocation} appended successfully.", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when appending to the file: {ex.Message}");
            }

        }
        public void ReplaceTextFormAFile(string fileLocation, string newContent, string oldContent)
        {
            // Edit the file at the specified location.
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Read the file content.
                string content = File.ReadAllText(fileLocation);
                // Replace the old content with the new content.
                content = content.Replace(oldContent, newContent);
                // Write the updated content back to the file.
                File.WriteAllText(fileLocation, content);
                Console.WriteLine($"File {fileLocation} edited successfully.", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when editing the file: {ex.Message}");
            }            
        }
        public void EditTextValueOfAFile(string fileLocation, string textObject, string newValue)
        {
            // Edit the file at the specified location.
            //string content = string.Empty;
            string oldContent = string.Empty; 
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                foreach (var line in File.ReadLines(fileLocation))
                {
                    // Check if the line contains the text object.
                    if (line.StartsWith(textObject))
                    {
                        // Replace the old content with the new content.
                        oldContent += textObject + newValue + Environment.NewLine;
                    }else
                    oldContent += line + Environment.NewLine;
                }
                // Write the updated content back to the file.
                File.WriteAllText(fileLocation, oldContent);
                
                Console.WriteLine($"File {fileLocation} edited successfully.", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when editing the file: {ex.Message}");
            }
        }
        public void DeleteFile(string fileLocation)
        {
            // Delete the file at the specified location.
            try
            {
                // Check if the file exists.
                if (!File.Exists(fileLocation))
                {
                    Console.WriteLine($"File {fileLocation} does not exist.", Console.ForegroundColor = ConsoleColor.Red);
                    return;
                }
                // Delete the file.
                File.Delete(fileLocation);
                Console.WriteLine($"File {fileLocation} deleted successfully.", Console.ForegroundColor = ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when deleting the file: {ex.Message}");
            }

        }
    }
}