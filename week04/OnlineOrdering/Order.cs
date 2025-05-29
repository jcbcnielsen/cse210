public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product p in _products)
        {
            total += p.GetWholePrice();
        }
        if (_customer.LivesInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"Item Name: {p.GetName()}, ID: {p.GetID()};\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}