public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }
    public override string GetAllDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
    public override string GetShortDescription()
    {
        return $"Type: Lecture\nEvent: {Title}\nDate: {Date.ToShortDateString()}";
    }
    // getters and setters
    public string Speaker
    {
        get { return _speaker; }
        set { _speaker = value; }
    }
    public int Capacity 
    {
        get { return _capacity; }
        set { _capacity = value; }
    }
}