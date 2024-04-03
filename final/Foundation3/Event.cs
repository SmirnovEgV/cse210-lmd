using System;

public class Event
{
    // Protected variables
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    // Constructor
    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.OuptutAddress();
    }

    
    // Method to display a standard message
    public void StandardMessage()
    {
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}\n");
    }

    // Method to display a long message
    public virtual void LongMessage()
    {
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Description: {_description}");
    }

    // Method to display a short message
    public void ShortMessage()
    {
        Console.WriteLine($"Event: {_type} ({_title})");
        Console.WriteLine($"Date: {_date}\n");
    }
}
