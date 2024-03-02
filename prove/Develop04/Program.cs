using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("\n Select a choice from the menu: ");
            if(int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.BreathingExersices();
                        break;
                    case 2:
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity listing = new ListingActivity();
                        listing.ListingExercises();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("\n Not an option. Choose from options above and input a number");
                        break;

                }

            }

        }
        while(choice != 4);
    }

}