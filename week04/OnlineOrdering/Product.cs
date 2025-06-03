public class Product
{
    private string _name;
    private int _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    // public string GetDisplayText()
    // {
    //     return $"{_name} (ID: {_productId}) - Price: {_pricePerUnit:C}, Quantity: {_quantity}, Total Cost: {GetTotalCost():C}";
    // }
}