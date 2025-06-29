using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Great job! You earned {Points} points!");
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetDetails()
    {
        return $"[∞] {Name} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
