using System;

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int lengthMinutes, double distanceKm) : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }


    public override double GetDistance()
    {
        return _distanceKm;

    }

    public override double GetSpeed()
    {
        return (_distanceKm / LengthMinutes) * 60;
    }


    public override double GetPace()
    {
        if (_distanceKm == 0)
            return 0;
        else
            return LengthMinutes / _distanceKm;
    }
}