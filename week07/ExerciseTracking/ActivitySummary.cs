using System;
using System.Collections.Generic;

public class ActivitySummary
{
    private List<Activity> _activities = new List<Activity>();

    public ActivitySummary() { }

    public void Start()
    {
        createActivity();
        DisplayActivity();

    }

    private void createActivity()
    {
        _activities.Add(new Running("03 Nov 2022", 30, 3));
        _activities.Add(new Swimming("03 Nov 2022", 30, 10));
        _activities.Add(new StationaryBicycles("03 Nov 2022", 30, 9.7));

    }

    private void DisplayActivity()
    {
        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

}