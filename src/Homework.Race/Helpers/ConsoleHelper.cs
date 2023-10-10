namespace Homework.Race;

public static class ConsoleHelper
{
    public static void Print(string message, int delay = 15)
    {
        foreach (var symbol in message.ToCharArray())
        {
            Console.Write(symbol);

            Thread.Sleep(delay);
        }

        Console.WriteLine();
    }
}

