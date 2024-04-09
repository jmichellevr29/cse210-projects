public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }
    public override string GetAllDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email{RSVPEmail}";
    }
    public override string GetShortDescription()
    {
        return $"Type: Reception\nEvent: {Title}\nDate: {Date.ToShortDateString()}";
    }
    
    // getters and setter 
    public string RSVPEmail 
    {
        get { return _rsvpEmail; }
        set { _rsvpEmail = value;}
    }
}