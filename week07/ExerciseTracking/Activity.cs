using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;

    }

    public DateTime Date
    {
        get { return _date; }

    }

    public int LengthMinutes
    {
        get { return _lengthMinutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthMinutes} min)- Distance {GetDistance():0.0} KM, Speed {GetSpeed():0.0} KPH, Pace: {GetPace():0.00} min per kilometer";
    }
}