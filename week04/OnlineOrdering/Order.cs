public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private const decimal SHIPPING_COST_USA = 5;
    private const decimal SHIPPING_COST_INTERNATIONAL = 35;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        if (_customer.LivesInUSA())
        {
            totalCost += SHIPPING_COST_USA;
        }
        else
        {
            totalCost += SHIPPING_COST_INTERNATIONAL;
        }

        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += _customer.GetAddress().GetFullAddress();
        return shippingLabel;
    }
}