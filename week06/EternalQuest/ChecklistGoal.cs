using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {

        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;

    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}