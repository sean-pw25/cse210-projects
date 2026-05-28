public class Product
{
    string _name;
    string _productId;
    float _price;
    int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        float total = _quantity * _price;
        return (float)Math.Round(total, 2);
    }

    public string GetProductInfo()
    {
        return $"{_name} - {_productId}";
    }
}