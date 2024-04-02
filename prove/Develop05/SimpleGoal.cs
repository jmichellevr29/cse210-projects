using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal (string name, string description, int points)
        : base (name, description, points)
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
    public override string GetStringRepresentation()
    {
        string completionStatus = _isCompleted ? "Completed" : "Not Completed";
        return $"{GetName()}: {completionStatus}"; 
    }
}