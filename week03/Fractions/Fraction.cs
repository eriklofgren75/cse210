using System;

class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholenumber)
    {
        top = wholenumber;
        bottom = 1;
    }
    public Fraction(int _top, int _bottom)
    {
        top = _top;
        bottom = _bottom;
    }
    public string GetFractionString()
    {
        string text = $"{top}/{bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)top / bottom;

    }
}
