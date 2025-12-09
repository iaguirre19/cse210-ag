using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override bool IsComplete => false;

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{Name}|{Description}|{Points}";
    }

    public override string GetDisplayText()
    {
        return $"[ ] {Name} ({Description}) -- {Points} pts each time";
    }
}
