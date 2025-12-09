using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete => _isComplete;

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }

        _isComplete = true;
        return Points;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal:{Name}|{Description}|{Points}|{IsComplete}";
    }
}
