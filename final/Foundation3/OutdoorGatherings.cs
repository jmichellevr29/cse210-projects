public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, string address, string weather)
        :base(title, description, date, time, address)
    {
        Weather = weather;
    }
    public override string GetAllDetails()
    {
        return$"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {Weather}";
    }
    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nEvent: {Title}\nDate: {Date.ToShortDateString()}";
    }
    // getters and setters 
    public string Weather 
    {
        get { return _weather; }
        set { _weather = value; }
    }
   
}