public class ReceptionEvent : Event
{
    // Private variable
    private string _pathToRegister;

    // Constructor
    public ReceptionEvent(string type, string title, string description, string date, string time, Address address, string pathToRegister) : base(type, title, description, date, time, address)
    {
        _pathToRegister = pathToRegister;
    }

    // Method to display detailed information about the event
    public override void LongMessage()
    {
        base.LongMessage(); // Call the base class's LongMessage method
        Console.WriteLine($"Registration Link: {_pathToRegister}\n");
    }
}
