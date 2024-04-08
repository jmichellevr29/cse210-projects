public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
    // getters and setter 
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetCustomerAddress()
    {
        return _address.GetFormattedAddress();
    }
    public Address Address
    {
        get { return _address; }
    }
}