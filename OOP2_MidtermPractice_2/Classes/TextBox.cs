namespace OOP2_MidtermPractice_2.Classes;

public static class TextBox
{
    public static void PrintText(string text, ConsoleColor colour = ConsoleColor.Gray, int delay_between = 0)
    {
        Console.ForegroundColor = colour;

        foreach (char letter in text)
        {
            Thread.Sleep(delay_between);
            Console.WriteLine(letter);
        }
    }

    public static void PrintSystemText(string text, ConsoleColor colour = ConsoleColor.Gray, int delay_between = 0)
    {
        Console.ForegroundColor = colour;

        Console.WriteLine("||");
        foreach (char letter in text)
        {
            Thread.Sleep(delay_between);
            Console.WriteLine(letter);
        }
        Console.WriteLine("||");

        RequestKeyPress();
    }

    public static void PrintSuspense(int dot_amount = 3, int delay_between = 750, string spacing = "  ")
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("\n");

        for (int i = 1; i <= dot_amount; i++)
        {
            Thread.Sleep(delay_between);
            Console.Write($".{spacing}");
        }
    }

    public static void RequestKeyPress()
    {
        Console.WriteLine("   (*)");
        Console.ReadKey();
    }

}


