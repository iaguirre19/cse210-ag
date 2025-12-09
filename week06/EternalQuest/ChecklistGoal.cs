using System;
class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete => _amountCompleted >= _targetCount;

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _targetCount)
        {
            return Points + _bonus;
        }

        return Points;
    }

    public override string GetDisplayText()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Completed {_amountCompleted}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal:{Name}|{Description}|{Points}|{_targetCount}|{_bonus}|{_amountCompleted}";
    }
}
