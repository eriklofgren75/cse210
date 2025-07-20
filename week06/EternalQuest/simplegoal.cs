using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;

    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return GetPoints();

        }
        return 0;

    }

    public override string GetStatus()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {GetName()} ({GetDescription()})";

    }

    public override string GetSaveString()
    {
        return $"Simple Goal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isCompleted}";
        
    }
}