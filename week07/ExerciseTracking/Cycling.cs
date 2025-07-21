using System;

public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int lengthMinutes, double speedKph) : base(date, lengthMinutes)
    {
        _speedKph = speedKph;

    }

    public override double GetDistance()
    {
        return (_speedKph * LengthMinutes) / 60;
    }


    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        if (_speedKph == 0)
            return 0;
        else
            return 60 / _speedKph;
    }

}
