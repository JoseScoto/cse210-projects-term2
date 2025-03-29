public class Order
{
    // Attributes
    private List<Product> _products;
    private Customer _customer;
    private const decimal USA_SHIPPING_COST = 5.00m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total order cost
    public decimal GetTotalCost()
    {
        decimal productTotal = _products.Sum(p => p.GetTotalCost());
        decimal shippingCost = _customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return productTotal + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.GetName()} (ID: {p.GetProductId()})"));
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
