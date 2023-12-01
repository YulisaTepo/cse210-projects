using System.Text;
public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    private double TotalCost() //WORKS!!
    {
        double cost = 0;
        foreach (Product product in _products)
        {
            double price = product.GetPrice();
            cost = cost + price;
        }
        int shippingCost = GetShippingCost();
        return shippingCost + cost;
    }

    private string GetPackingLabel()
    {
        StringBuilder stringB = new StringBuilder();
        foreach (var product in _products)
        {
            stringB.AppendLine(product.toString());
        }
        return stringB.ToString();
    }

    private string GetShippingLabel() //Displays Customer name and Address
    {
        return _customer.GetCustomer();
    }

    private int GetShippingCost() //WORKS!
    {
        if (_customer.CheckIsInUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void AddProduct(Product product) //Added product from Program
    {
        _products.Add(product);
    }

    public string GetResult()
    {
        return @$"
PACKING LABEL 
{GetPackingLabel()}
SHIPPING LABEL {GetShippingLabel()} 

TOTAL COST: ${TotalCost()}";
    }
}