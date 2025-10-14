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

    public static void PrintSystemText(string text)
    {
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine("||");
        foreach (char letter in text)
        {
            Thread.Sleep(50);
            Console.WriteLine(letter);
        }
        Console.WriteLine("||");
        Console.WriteLine("    (*)");
    }

}


