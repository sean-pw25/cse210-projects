using System.Globalization;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return (float)Math.Round(total, 2);
    }

    public string GetPackingLabel() // name and products including product id
    {
        string packingLabel = "";
        int num = 0;
        foreach (Product product in _products)
        {
            num += 1;
            packingLabel += $"{num}. {product.GetProductInfo()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() // name and address of customer
    {
        return _customer.GetShippingInfo();
    }
}