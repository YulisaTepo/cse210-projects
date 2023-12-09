public class Address
{
    private string _streetAddress;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _streetAddress = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool IsInUSA()
    {
        //if (_country == "USA")
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
        return _country.ToUpper() == "USA";
    }
    public string toString()
    {
        return $"{_streetAddress}, {_city}, {_province}, {_country}";
    }
}