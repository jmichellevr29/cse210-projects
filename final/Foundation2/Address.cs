using System.Security.Authentication;

public class Address 
{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _country { get; set; }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country == "USA";
    }
    public string GetFormattedAddress()
    {
        string formattedAddress = $"{_street}\n{_city}, {_state}\n{_country}";
        return formattedAddress;
    }
    // getters and setters 
    public string GetCountry()
    {
        return _country;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetStreet()
    {
        return _street;
    }
}