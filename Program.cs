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
            "Exit",
        };
        int selectedIndex = 0;
        bool exit = false;

        Console.Clear();
        PrintTitle("Welcome to this cool interactive menu!", ConsoleColor.Yellow);
        PrintTitle("Use Arrow Keys to navigate, and Enter to select.", ConsoleColor.Green);

        RenderMenu(menuOptions, selectedIndex);

        while (!exit)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            int previousIndex = selectedIndex;

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

            if (selectedIndex != previousIndex)
            {
                UpdateMenuOption(menuOptions, previousIndex, false);
                UpdateMenuOption(menuOptions, selectedIndex, true);
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

    static void RenderMenu(List<string> options, int selectedIndex)
    {
        for (int i = 0; i < options.Count; i++)
        {
            UpdateMenuOption(options, i, i == selectedIndex);
        }
    }

    static void UpdateMenuOption(List<string> options, int index, bool isSelected)
    {
        Console.SetCursorPosition(0, index + 3);
        if (isSelected)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"> {options[index].PadRight(Console.WindowWidth - 1)}");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"  {options[index].PadRight(Console.WindowWidth - 1)}");
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
                PrintTitle("Exiting the menu...", ConsoleColor.Red);
                Thread.Sleep(1000);
                exit = true;
                break;
        }

        if (!exit)
        {
            Console.Clear();
            PrintTitle("Welcome to this cool interactive menu!", ConsoleColor.Yellow);
            PrintTitle("Use Arrow Keys to navigate, and Enter to select.", ConsoleColor.Green);
            RenderMenu(
                new List<string> { "Hello, World!", "Test text 1", "Test text 2", "Exit" },
                0
            );
        }
    }

    static void ShowLoadingBar(ConsoleColor color)
    {
        Console.WriteLine();
        Console.ForegroundColor = color;
        Console.Write("Loading: [");
        for (int i = 0; i < 20; i++)
        {
            Console.Write("#");
            Thread.Sleep(100);
        }
        Console.WriteLine("]");
        Console.ResetColor();
    }
}
