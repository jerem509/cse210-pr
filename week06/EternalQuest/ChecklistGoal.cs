using System;

public class ChecklistGoal: Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(int amount, int target, int bonus, string name, string description, string points): base(name, description, points) 
    {
        _amountCompleted = amount;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(int target, int bonus, string name, string description, string points): base(name, description, points) 
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations. You have earned {_points} points.");
        if (IsComplete() == true) 
        {
            int eventPoints = int.Parse(_points) + _bonus;
            _points = eventPoints.ToString();
        }
    }
    
    public override bool IsComplete()
    {
        if (_amountCompleted/_target == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string isChecked;
        if (IsComplete() == true) {
            isChecked = "[X]";
        }
        else 
        {
            isChecked = "[ ]";
        }
        
        return $"{isChecked} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName};{_description};{_points};{_bonus};{_target};{_amountCompleted}";
    }
}
