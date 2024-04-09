public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time; 
    private string _address;
    
    public Event(string title, string description, DateTime date, TimeSpan time, string address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }
    public virtual string GetStandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }
    public virtual string GetAllDetails()
    {
        return GetStandardDetails();
    }
    public virtual string GetShortDescription()
    {
        return $"Type: Generic Event\nEvent: {Title}\nDate: {Date.ToShortDateString()}";
    }

    // getters and setters
    public string Title 
    {
        get { return _title; }
        set { _title = value; }
    }
    public string Description 
    {
        get { return _description; }
        set { _description = value;}
    }
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public TimeSpan Time
    {
        get { return _time; }
        set { _time = value; }
    }
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    
}