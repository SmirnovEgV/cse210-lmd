using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        int choice;
        do
        {
            Console.WriteLine($"You have {points} points \n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");

            Console.Write("Select a choice from the menu: ");
            if(int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        // create a new goal one out of 3
                        // call a thing and use there switch
                        // add negative goals that whenever happen will deduct points.
                        // can be eternal, simple or complex
                        break;
                    case 2:
                        // list things that where created originally
                        break;
                    case 3:
                        // Save things to a txt file
                        break;
                    case 4:
                        // load things from txt file
                        break;
                    case 5:
                        // record goal completion
                        break;
                    case 6:
                        Console.WriteLine("Exiting the application...");
                        Thread.Sleep(2500);
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