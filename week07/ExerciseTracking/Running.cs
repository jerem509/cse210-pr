using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _time) * 60;
    }
    public override double GetPace()
    {
        return _time / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_time})- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }


}