namespace ConsoleMenu;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuOptions = new List<string>
        {
            "Hello, World!",
            "Test text 1",
            "Test text 2",
            "Test text 3",
        };
        int selectedIndex = 0;
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            PrintTitle("Welcome to the Cool Interactive Menu!", ConsoleColor.Yellow);
            PrintAnimatedLine(
                "Use Arrow Keys to navigate, and Enter to select.",
                ConsoleColor.Green
            );

            // Display the menu
            for (int i = 0; i < menuOptions.Count; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"> {menuOptions[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {menuOptions[i]}");
                }
            }

            // Handle user input
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex =
                        (selectedIndex == 0) ? menuOptions.Count - 1 : selectedIndex - 1;
                    break;

                case ConsoleKey.DownArrow:
                    selectedIndex =
                        (selectedIndex == menuOptions.Count - 1) ? 0 : selectedIndex + 1;
                    break;

                case ConsoleKey.Enter:
                    HandleSelection(menuOptions[selectedIndex], ref exit);
                    break;

                default:
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine("Thanks for using the interactive menu! Goodbye!");
    }

    static void PrintTitle(string title, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        foreach (char c in title)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
        Console.ResetColor();
    }

    static void PrintAnimatedLine(string line, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(30);
            Console.WriteLine();
            Console.ResetColor();
        }
    }

    static void HandleSelection(string option, ref bool exit)
    {
        Console.Clear();
        switch (option)
        {
            case "Hello, World!":
                PrintTitle("Hello, World", ConsoleColor.Green);
                Thread.Sleep(1000);
                break;

            case "Test text 1":
                PrintTitle("Test text 1", ConsoleColor.Magenta);
                Thread.Sleep(1000);
                break;

            case "Test text 2":
                PrintTitle("Test text 2", ConsoleColor.Blue);
                Thread.Sleep(1000);
                break;

            case "Exit":
                PrintTitle("Exit", ConsoleColor.Red);
                Thread.Sleep(1000);
                exit = true;
                break;
        }
    }
}
