using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int GetAmountCompleted() => _amountCompleted;
    public int GetTarget() => _target;

    public override bool IsComplete()
    {
        // TODO: complete when amount >= target
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        // TODO:
        // 1) if already complete: return 0 (or still allow? your choice, but be consistent)
        // 2) increment _amountCompleted
        // 3) return points; if now complete, add bonus ONCE (on the completion event)
        return 0;
    }

    public override string GetDetailsString()
    {
        // TODO: format:
        // "[ ] Name (Description) -- Completed x/y times"
        string mark = IsComplete() ? "X" : " ";
        return $"[{mark}] {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        // Example: "Checklist|name|desc|points|target|bonus|amountCompleted"
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
