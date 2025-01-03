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
            PrintTitle(
                "Test text in this title hello world, how are you doing today",
                ConsoleColor.Cyan
            );
        }
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

                case "Test text 3":
                    PrintTitle("Test text 3", ConsoleColor.Red);
                    Thread.Sleep(1000);
                    exit = true;
                    break;
            }
        }
    }
}
