using System;
using System.Collections.Generic;

public class EventInteractor
{
    private List<Event> _listOfEvents;

    // Constructor
    public EventInteractor()
    {
        _listOfEvents = new List<Event>();
    }

    // Method to output the list of events
    public void OutputListOfEvents()
    {
        foreach (var ev in _listOfEvents)
        {
            ev.ShortMessage();
        }
    }

    // Method to create an event
    public void CreateAnEvent()
    {
        switch()
        {
            case EventType.Lecture:
                Event lectureEvent = new LectureEvent();
                _listOfEvents.Add(lectureEvent);
        }
        

        Event receptionEvent = new ReceptionEvent();
        _listOfEvents.Add(receptionEvent);

        Event outdoorEvent = new OutdoorEvent();
        _listOfEvents.Add(outdoorEvent);
    }

    // Method to choose an event and message type
    public void ChooseEventAndMessageType(int eventIndex, MessageType messageType)
    {
        if (eventIndex < 0 || eventIndex >= _listOfEvents.Count)
        {
            Console.WriteLine("Invalid event index.");
            return;
        }

        Event selectedEvent = _listOfEvents[eventIndex];

        switch (messageType)
        {
            case MessageType.Standard:
                selectedEvent.StandardMessage();
                break;
            case MessageType.Long:
                selectedEvent.LongMessage();
                break;
            case MessageType.Short:
                selectedEvent.ShortMessage();
                break;
            default:
                Console.WriteLine("Invalid message type.");
                break;
        }
    }
}


