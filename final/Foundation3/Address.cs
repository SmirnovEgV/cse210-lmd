public class Address 
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string OuptutAddress()
    {
        string address = $"{_street}, {_city}, {_stateOrProvince}, {_country}";
        return address;
    }
    public Address CreateAddress()
    {
        Address address = new Address("","","","");
        return address;
    }
}