class Program
{
    static void Main(string[] args)
    {
        EventInteractor eventInteractor = new EventInteractor();

        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create an event");
            Console.WriteLine("2. Output list of events");
            Console.WriteLine("3. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    eventInteractor.CreateAnEvent();
                    break;
                case "2":
                    eventInteractor.OutputListOfEvents();
                    break;
                case "3":
                    quit = true;
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}