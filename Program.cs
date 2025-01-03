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
            Thread.Sleep(30); // Faster animation for smaller text
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}
