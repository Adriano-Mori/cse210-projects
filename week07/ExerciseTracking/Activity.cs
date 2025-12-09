using System;
using System.Runtime.CompilerServices;
public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _minutes;

    public Activity(string name, string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        _name = name;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date}{_name} ({_minutes}): " +
         $"Distance: {GetDistance():0.00} km, " +
         $"Speed: {GetSpeed()} kph, " +
         $"Pace: {GetPace()} min per km ";
    }
}