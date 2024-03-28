public class Product 
{
    private string _title;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string title, int id, double price, int quantity)
    {
        _title = title;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductLine()
    {
        return $"{_productId} | {_title} -- ${_price} X {_quantity}";
    }

    public double GetCost()
    {
        double cost = _price * _quantity;
        return cost;
    }

}