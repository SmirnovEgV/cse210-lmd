public class Order 
{
    Customer _customer;
    List<Product> _items = new List<Product>(); 

    public Order(string customerName)
    {   
        _customer = new Customer(customerName);
    }
    public void GenerateItem(string titlePassed, int idPassed, double pricePassed, int quantityPassed)
    {
        string title = titlePassed; //Console.ReadLine();
        int id = idPassed; //int.Parse(Console.ReadLine());
        double price = pricePassed; //double.Parse(Console.ReadLine());
        int quantity = quantityPassed; //int.Parse(Console.ReadLine());
        Product product = new Product(title,id,price,quantity);
        _items.Add(product);
    }
    private string GetTotalPrice()
    {
        double totalPrice;
        int shipping;
        string inUs = _customer.IsInUS();
        if (inUs == "US")
        {
            totalPrice = 5;
            shipping = 5;
        }
        else
        {
            totalPrice = 35;
            shipping = 35;
        } 

            foreach (Product product in _items)
            {
                double itemsCost =  product.GetCost();
                totalPrice += itemsCost;
            }
            return $"Your total product price is ${totalPrice} from which shipping is ${shipping}.";
    }

    public void GetPackagingLable()
    {
        if (_items.Count <= 0)
        { 
            Console.WriteLine("The list of items is empty, total price is 0");
        }
        else
        {
            string totalString = GetTotalPrice();
            foreach (Product product in _items)
                {
                    product.GetProductLine();
                }
        
            Console.WriteLine($"\n");
        }
    }
    public void GetShippingLable()
    {
        Console.WriteLine("Customer Name and address");
        Console.WriteLine(_customer.GetCustomerInfo());
    }

}