class Program
{
    static void Main(string[] args)
    {
        EventInteractor eventInteractor = new EventInteractor();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create an event");
            Console.WriteLine("2. Output list of events");
            Console.WriteLine("3. Quit");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                 switch (choice)
            {
                case 1:
                    eventInteractor.CreateAnEvent();
                    break;
                case 2:
                    eventInteractor.OutputListOfEvents();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    eventInteractor.ChooseEventAndMessageType();
                    break;
                case 4:
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
            }
        }
        while (choice != 4);
    }
}