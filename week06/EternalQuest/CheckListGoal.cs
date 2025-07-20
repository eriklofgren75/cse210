using System;
using System.Reflection;

public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;

    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int totalPoints = GetPoints();
            if (_currentCount == _targetCount)
            {
                totalPoints += _bonusPoints;
            }
            return totalPoints;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount} times";

    }

    public override string GetSaveString()
    {
        return $"Checklist Goal|{GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_bonusPoints}|{_currentCount}";

    }


    
}