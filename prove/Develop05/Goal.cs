using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
    
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    protected string GetCompletionMark()
    {
        return IsComplete() ? "X" : " ";
    }
}
