using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration; // seconds

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void Start()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
        RunCore();
        Console.WriteLine();

        DisplayEndingMessage();
        ShowSpinner(3);
    }

    public void SetDuration(int seconds)
    {
        _duration = Math.Max(0, seconds);
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected string GetName()
    {
        return _name;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        int seconds = ReadIntFromUser();
        SetDuration(seconds);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name} Activity.");
    }

    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // erase the digit
        }
    }

    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    protected int ReadIntFromUser()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value > 0)
                return value;

            Console.Write("Please enter a positive whole number: ");
        }
    }

    protected abstract void RunCore();
}
