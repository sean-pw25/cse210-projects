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
        return _address.LivesInUSA();
    }

    public string GetShippingInfo()
    {
        return $"Name: {_name}\n{_address.GetFullAddress()}";
    }
}