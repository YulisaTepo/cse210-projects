using System.Text;

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
        StringBuilder sb = new StringBuilder();
        sb.Append($"Customer: {_name} |");
        sb.Append($" Address: {_address.toString()}");
        return sb.ToString();
    }
}