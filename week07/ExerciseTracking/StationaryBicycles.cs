using System;

public class StationaryBicycles : Activity
{
    private double _speed = 0;

    public StationaryBicycles(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_time * _speed) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} StationaryBicycle ({_time})- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}