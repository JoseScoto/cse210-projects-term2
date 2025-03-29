public class Customer
{
    // Attributes
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer is in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter methods
    public string GetName() => _name;
    public Address GetAddress() => _address;
}