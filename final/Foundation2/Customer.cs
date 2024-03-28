public class Customer 
{
    private string _name;
    private Address _address;
    public Customer(string name)
    {
        _name = name;
        _address = CreateAddress(); 
    }
    public Address CreateAddress()
    {   
        Console.WriteLine("Enter the street, house number and appartment if needed");
        string street = Console.ReadLine(); // "Lobonka 78 - 112";
        Console.WriteLine("Enter the city");
        string city = Console.ReadLine(); // "Minsk";
        Console.WriteLine("Enter the state, provice, region or district");
        string stateOrProvince = Console.ReadLine(); //"Central";
        Console.WriteLine("Enter the Country in code format ie US, GB, RU");
        string country = Console.ReadLine(); //"Belarus";
        Address address = new Address(street,city,stateOrProvince,country);
        return address;
    }

    public string GetCustomerInfo()
    {   
        string address = _address.GetFormattedAddress();
        string info = $"\tName: \n{_name} \n\tAddress: \n{address}";
        return info;
    }
    public string IsInUS()
    {
        string country = _address.GetCountry();
        return country;
    }

}