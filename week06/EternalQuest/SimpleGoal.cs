using System;

public class SimpleGoal: Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points): base(name, description, points) {}
    public SimpleGoal(bool completed, string name, string description, string points): base(name, description, points) 
    {
        _isComplete = completed;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations. You have earned {_points} points.");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName};{_description};{_points};{_isComplete}";
    }
}