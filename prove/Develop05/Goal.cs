public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private int _progress;



    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _progress = 0;
    }
    public virtual void RecordEvent()
    {
        _progress++;
    }
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Points: {_points}";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}: {_progress}/{_points}";
    }
    public virtual int GetBonusPoints()
    {
        return 0;
    }
    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetProgress(int progress)
    {
        _progress = progress;
    }
}