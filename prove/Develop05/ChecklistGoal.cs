public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
       : base(name, description, points)
    {
        _target = target;
        _bonus = bonus; 
        _amountCompleted = 0;
    }
    public override int GetBonusPoints()
    {
        return IsComplete() ? _bonus : 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{GetName()}: {GetDescription()} - Points: {GetPoints()}, Taget {_target}, Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetName()}: {_amountCompleted}/{_target} completed";
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
}