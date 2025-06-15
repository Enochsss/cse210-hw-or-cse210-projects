public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isCompleted ? "X" : " ")}] {_shortName} - {_description} ({_points} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{(_isCompleted ? "1" : "0")}";
    }
}