namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // a simple hello welcome message before the main menu
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Enter any key to Continue...");
            Console.ReadKey();
            Console.Clear();
            Menu.MainMenu();
        }
    }
}