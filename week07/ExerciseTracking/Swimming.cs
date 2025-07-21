using System;

public class Swimming : Activity
{
    private int _laps;


    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;

    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }


    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0)
            return 0;
        else
            return LengthMinutes / distance;
    }
}
