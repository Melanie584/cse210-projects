using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        int totalPoints = Points;
        if (_timesCompleted == _targetCount)
        {
            totalPoints += _bonusPoints;
            Console.WriteLine("Bonus achieved!");
        }
        Console.WriteLine($"Nice work! You earned {totalPoints} points.");
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDetails()
    {
        return $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {Name} ({Description}) -- Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonusPoints}|{_targetCount}|{_timesCompleted}";
    }
}
