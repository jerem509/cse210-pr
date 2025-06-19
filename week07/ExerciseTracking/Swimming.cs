using System;

public class Swimming : Activity
{
    private int _numberOfLaps = 0;

    public Swimming(string date, double time, int numberOfLaps) : base(date, time)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (_numberOfLaps * 50 / 1000) * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _time;
    }
    public override double GetPace()
    {
        return _time / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_time})- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}