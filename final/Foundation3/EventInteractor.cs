public class EventInteractor
{
    // CREATED AS A WAY TO INPUT EVENTS MANUALLY AND CHOOSE OUTPUT

    // private List<Event> _listOfEvents;

    // // Constructor
    // public EventInteractor()
    // {
    //     _listOfEvents = new List<Event>();
    // }

    // // Method to output the list of events
    // public void OutputListOfEvents()
    // {
    //     foreach (var singleEvent in _listOfEvents)
    //     {
    //         singleEvent.LongMessage();
    //     }
    // }

    // public void CreateAnEvent()
    // {
    //     Console.Clear();
    //     Console.WriteLine("What type of event would you like to create?");
    //     Console.WriteLine("1. Lecture");
    //     Console.WriteLine("2. Reception");
    //     Console.WriteLine("3. Outdoor");
    //     Console.WriteLine("4. Quit");

    //     string choice = Console.ReadLine();

    //     switch(choice)
    //     {
    //         case "1":
    //             Console.WriteLine("Creating a Lecture Event...");
    //             LectureEvent lectureEvent = CreateLectureEvent();
    //             _listOfEvents.Add(lectureEvent);
    //             break;
    //         case "2":
    //             Console.WriteLine("Creating a Reception Event...");
    //             ReceptionEvent receptionEvent = CreateReceptionEvent();
    //             _listOfEvents.Add(receptionEvent);
    //             break;
    //         case "3":
    //             Console.WriteLine("Creating an Outdoor Event...");
    //             OutdoorEvent outdoorEvent = CreateOutdoorEvent();
    //             _listOfEvents.Add(outdoorEvent);
    //             break;
    //         case "4":
    //             Console.WriteLine("Quitting...");
    //             break;
    //         default:
    //             Console.WriteLine("Invalid choice. Please select a valid option.");
    //             break;
    //     }
    // }

    // public void ChooseEventAndMessageType() 
    // {
    //     _listOfEvents
        
    // }

    // private LectureEvent CreateLectureEvent()
    // {
    //     Tuple<string, string, string, string> eventData = GetUserEventData();

    //     if (eventData != null)
    //     {
    //         Console.WriteLine("Enter the presenter's name:");
    //         string presenterName = Console.ReadLine();
    //         Console.WriteLine("Enter the capacity:");
    //         int capacity = int.Parse(Console.ReadLine());

    //         Address address = CreateAddress();

    //         LectureEvent lectureEvent = new LectureEvent("Lecture", eventData.Item1, eventData.Item2,
    //                                                      eventData.Item3, eventData.Item4, address, presenterName, capacity);
    //         return lectureEvent;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid event data. Lecture event creation failed.");
    //         return null;
    //     }
    // }
    
    // private ReceptionEvent CreateReceptionEvent()
    // {
    //     Tuple<string, string, string, string> eventData = GetUserEventData();

    //     if (eventData != null)
    //     {
    //         Console.WriteLine("Enter the registration address:");
    //         string registrationAddress = Console.ReadLine();

    //         Address address = CreateAddress();

    //         ReceptionEvent receptionEvent = new ReceptionEvent("Reception", eventData.Item1, eventData.Item2,
    //                                                      eventData.Item3, eventData.Item4, address, registrationAddress);
    //         return receptionEvent;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid event data. Reception event creation failed.");
    //         return null;
    //     }
    // }
    
    // private OutdoorEvent CreateOutdoorEvent()
    // {
    //     Tuple<string, string, string, string> eventData = GetUserEventData();

    //     if (eventData != null)
    //     {
    //         Console.WriteLine("Enter the weather:");
    //         string weather = Console.ReadLine();

    //         Address address = CreateAddress();

    //         OutdoorEvent outdoorEvent = new OutdoorEvent("Outdoor", eventData.Item1, eventData.Item2,
    //                                                         eventData.Item3, eventData.Item4, address, weather);
    //         return outdoorEvent;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid event data. Outdoor event creation failed.");
    //         return null;
    //     }
    // }

    // private Address CreateAddress()
    // {
    //     Console.WriteLine("Please input an address:");
    //     Console.WriteLine("Street and number");
    //     string street = Console.ReadLine();
    //     Console.WriteLine("City");
    //     string city = Console.ReadLine();
    //     Console.WriteLine("State or Province or Region");
    //     string stateOrProvince = Console.ReadLine();
    //     Console.WriteLine("Country");
    //     string country = Console.ReadLine();
    //     Address address = new Address(street,city,stateOrProvince,country );
    //     return address;
    // }
    // private Tuple<string, string, string, string> GetUserEventData()
    // {
    //     // Prompt the user for the event name
    //     Console.WriteLine("How will the event be called?");
    //     string name = Console.ReadLine();

    //     // Prompt the user to describe the event
    //     Console.WriteLine("Describe what's going to happen there:");
    //     string description = Console.ReadLine();

    //     // Prompt the user for the date
    //     Console.WriteLine("Enter the date (YYYY-MM-DD):");
    //     string dateString = Console.ReadLine();

    //     // Prompt the user for the time
    //     Console.WriteLine("Enter the time (HH:MM:SS):");
    //     string timeString = Console.ReadLine();
       
    //     return Tuple.Create(name, description, dateString, timeString);
    // }
        
}