public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        
    }
    public string GetName()
    {
        return _name;
    }

    public bool CheckIsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomer()
    {
        return @$"
Customer: {_name} | Address: {_address.toString()}";
    }
}