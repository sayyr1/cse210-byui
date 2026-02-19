using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, bool isComplete = false)
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete()
    {
        // TODO: return completion state
        return _isComplete;
    }

    public override int RecordEvent()
    {
        // TODO:
        // If not complete: set _isComplete = true and return points
        // If already complete: return 0 (or keep score unchanged)
        return 0;
    }

    public override string GetDetailsString()
    {
        // TODO: include [X]/[ ] using IsComplete()
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        // TODO: choose a consistent save format
        // Example: "Simple|name|desc|points|isComplete"
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}
