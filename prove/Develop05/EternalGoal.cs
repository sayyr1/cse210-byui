using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    { }

    public override bool IsComplete()
    {
        // TODO: Eternal goals never complete
        return false;
    }

    public override int RecordEvent()
    {
        // TODO: always give points every time
        return 0;
    }

    public override string GetDetailsString()
    {
        // TODO: should always look incomplete (or special marker if you want)
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        // Example: "Eternal|name|desc|points"
        return $"Eternal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}
