public class Product
{
    // Attributes
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost of product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getter methods
    public string GetName() => _name;
    public string GetProductId() => _productId;
}
