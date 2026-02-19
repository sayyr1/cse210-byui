using System;

public static class ConsoleHelpers
{
    public static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }

    public static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.WriteLine($"Please enter a valid number between {min} and {max}.");
        }
    }

    public static void Pause()
    {
        Console.Write("Press ENTER to continue...");
        Console.ReadLine();
    }
}
