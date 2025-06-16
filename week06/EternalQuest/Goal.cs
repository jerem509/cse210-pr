using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;  

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetGoalName() 
    {
        return _shortName;
    }

    public string GetGoalPoints() 
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString() 
    {
        string isChecked;
        if (IsComplete() == true) {
            isChecked = "[X]";
        }
        else 
        {
            isChecked = "[ ]";
        }
        return $"{isChecked} {_shortName} ({_description})";
    }   

    public abstract string GetStringRepresentation();

}