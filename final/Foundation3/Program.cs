class Program
{
    static void Main(string[] args)
    {
        List<Event> _listOfEvents = new List<Event>();

        Address address1 = new Address("New Street Alpha 92 92", "Kuram", "", "Kuwait");
        Address address2 = new Address("Street Beta 222A", "Dresden", "", "Germany");
        Address address3 = new Address("Street Gamma-Jojo 1", "Ashton", "South Carolina", "United States");

        Event lectureEvent = new LectureEvent("Lecture", "Some Lecture Event", "We will hear a lecture about mother of all lectures",
                                               "21 March 2024", "14:00", address2, "Peter Frederic Strause", 65);

        Event receptionEvent = new ReceptionEvent("Reception", "Some Reception Event", "A Nice and cozy dinner party for married couples of N company",
                                               "July 11, 2024", "7:45 PM", address3, "www.registar.cc.gov");

        Event outdoorEvent = new OutdoorEvent("Outdoor", "Some outdoor event", "Come and join community us at community celebration of Rahmadan",
                                       "2024-05-15", "09:45", address1, "Cloduy, +27");
        _listOfEvents.Add(lectureEvent);
        _listOfEvents.Add(receptionEvent);
        _listOfEvents.Add(outdoorEvent);
        
        Console.WriteLine("Standart message output:");
        foreach (var singleEvent in _listOfEvents)
        {
            singleEvent.StandardMessage();
        }

        Console.WriteLine("Long message output:");
        foreach (var singleEvent in _listOfEvents)
        {
            singleEvent.LongMessage();
        }

        Console.WriteLine("Short message output:");
        foreach (var singleEvent in _listOfEvents)
        {
            singleEvent.ShortMessage();
        }

    }
}