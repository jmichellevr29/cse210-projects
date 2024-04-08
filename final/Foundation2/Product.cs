public class Product
{
    private string _name { get; set; }
    private string _productID { get; set; }
    private float _pricePerUnit { get; set; }
    private int _quantity { get; set; }
    public Product(string name, string productID, float priceOfProduct, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = priceOfProduct;
        _quantity = quantity;
    }
    public float CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // getters and setters 
    public float GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    // getters and setters
    public string GetProductName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productID;
    }

}