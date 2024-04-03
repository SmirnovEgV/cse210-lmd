using System;

public class LectureEvent : Event
{
    // Private variables
    private string _presenterName;
    private int _capacity;

    // Constructor
    public LectureEvent(string type, string title, string description, string date, string time, Address address, string presenterName, int capacity) : base(type, title, description, date, time, address)
    {
        _presenterName = presenterName;
        _capacity = capacity;
    }

    // Method to override LongMessage from the base class
    public override void LongMessage()
    {
        base.LongMessage(); // Call the base class's LongMessage method
        Console.WriteLine($"Presenter: {_presenterName}");
        Console.WriteLine($"Capacity: {_capacity}\n");
    }
}
