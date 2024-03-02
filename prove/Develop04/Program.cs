using System;

class Program
{
    static List<BreathingActivity> breathingActivities = new List<BreathingActivity>();
    static List<ReflectingActivity> reflectingActivities = new List<ReflectingActivity>();
    static List<ListingActivity> listingActivities = new List<ListingActivity>();
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Show activities done count");
            Console.WriteLine("5. Quit");

            Console.Write("\n Select a choice from the menu: ");
            if(int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.BreathingExersices();
                        breathingActivities.Add(breathing);
                        break;
                    case 2:
                        Console.Clear();
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.ReflectingExersices();
                        reflectingActivities.Add(reflecting);
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity listing = new ListingActivity();
                        listing.ListingExercises();
                        listingActivities.Add(listing);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("The activities you've done for now");
                        Console.WriteLine($"Breathing Activity done: {breathingActivities?.Count() ?? 0}");
                        Console.WriteLine($"Reflecting Activity done: {reflectingActivities?.Count() ?? 0}");
                        Console.WriteLine($"Listing Activity done: {listingActivities?.Count() ?? 0}");
                        Console.WriteLine("Press enter to return to menu: ");
                        Console.Read();

                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("\n Not an option. Choose from options above and input a number");
                        break;

                }

            }

        }
        while(choice != 5);
    }

}