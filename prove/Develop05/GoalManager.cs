using System;
using System.Collections.Generic;

public class GoalManager
{
    private readonly List<Goal> _goals = new();
    private int _score = 0;

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals (coming next commit)");
            Console.WriteLine("  4. Load Goals (coming next commit)");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            string choice = ConsoleHelpers.ReadString("Select a choice from the menu: ");

            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    Console.WriteLine("Save will be implemented in the next commit.");
                    break;
                case "4":
                    Console.WriteLine("Load will be implemented in the next commit.");
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
            ConsoleHelpers.Pause();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        int type = ConsoleHelpers.ReadInt("Which type of goal would you like to create? ", 1, 3);

        string name = ConsoleHelpers.ReadString("What is the name of your goal? ");
        string desc = ConsoleHelpers.ReadString("What is a short description of it? ");
        int points = ConsoleHelpers.ReadInt("What is the amount of points associated with this goal? ", 1, 1_000_000);

        Goal newGoal;

        if (type == 1)
        {
            newGoal = new SimpleGoal(name, desc, points);
        }
        else if (type == 2)
        {
            newGoal = new EternalGoal(name, desc, points);
        }
        else
        {
            int target = ConsoleHelpers.ReadInt("How many times does this goal need to be accomplished for a bonus? ", 1, 1_000_000);
            int bonus = ConsoleHelpers.ReadInt("What is the bonus for accomplishing it that many times? ", 0, 1_000_000);

            newGoal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created!");
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        int selection = ConsoleHelpers.ReadInt("Which goal did you accomplish? ", 1, _goals.Count);
        Goal chosen = _goals[selection - 1];

        int earned = chosen.RecordEvent(); // polymorphism happens here
        _score += earned;

        if (earned > 0)
        {
            Console.WriteLine($"Congratulations! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("That goal is already complete (or no points awarded).");
        }

        Console.WriteLine($"You now have {_score} points.");
    }
}
