using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float CalculateTotalCost()
    {
        float _totalCost = _products.Sum(p => p.GetPricePerUnit());
        float _shippingCost = _customer.GetCustomerAddress()  == "USA" ? 5 : 35;
        return _totalCost + _shippingCost;
    }
    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetProductName()} - {product.GetProductId()}");
        }
        return label.ToString();
    }
    public string ShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine($"Customer name: {_customer.GetCustomerName()}");
        label.AppendLine($"Address: {_customer.Address.GetFormattedAddress()}");
        return label.ToString();
    }
}