using System;

public abstract class Goal
{
    // Core shared state (encapsulation: keep fields private)
    private string _shortName;
    private string _description;
    private int _points;

    // Constructor sets up the initial state for all goals.
    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Read-only accessors (encapsulation)
    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Polymorphic contract:
    // Each goal type decides completion rules, scoring rules, and serialization.
    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();

    // Virtual so derived types can override formatting if they want.
    public virtual string GetDetailsString()
    {
        // TODO: Return something like:
        // "[ ] Name (Description)"
        // For completed goals: "[X] ..."
        // NOTE: Checklist goals will override to add "Completed x/y times"
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    // Helper for derived classes (optional).
    protected string GetCompletionMark()
    {
        return IsComplete() ? "X" : " ";
    }
}
