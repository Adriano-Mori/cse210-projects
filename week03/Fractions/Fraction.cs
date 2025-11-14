using System;
public class Fraction
{
    private int _top;
    private int _bottom;
    // constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //constructor 2
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //constructor 3
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }
    //getter
    public int GetTop()
    {
        return _top;
    }
    //setter
    public void SetTop(int top)
    {
        _top = top;
    }
    //getter 2
    public int GetBottom()
    {
        return _bottom;
    }
    //setter 2
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
