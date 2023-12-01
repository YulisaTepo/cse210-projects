public class Product
{
    private string _name;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int ID, int price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price * _quantity;
    }
    public string toString()
    {
        return $"Product: {_name} (ID {_productID})";
    }
}