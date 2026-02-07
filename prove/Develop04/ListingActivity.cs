using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _items = new List<string>();
    private Random _rand = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
          )
    { }

    protected override void RunCore()
    {
        _items.Clear();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item.Trim());
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items!");
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}
