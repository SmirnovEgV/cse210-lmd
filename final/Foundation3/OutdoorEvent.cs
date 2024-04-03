public class OutdoorEvent : Event
{
    // Private variable
    private string _weather;

    // Constructor
    public OutdoorEvent(string type, string title, string description, string date, string time, Address address, string weather) 
    : base(type, title, description, date, time, address)
{
    _weather = weather;
}

    // Method to display detailed information about the event
    public override void LongMessage()
    {
        base.LongMessage(); // Call the base class's LongMessage method
        Console.WriteLine($"Weather Forecast: {_weather}");
    }
}
