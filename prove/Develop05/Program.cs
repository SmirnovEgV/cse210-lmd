using System;

class Program
{
    static void Main(string[] args)
    {   
        GoalInteractor goalInteractor = new GoalInteractor();
        int points = 0;
        int choice;
        
        do
        {
            points = goalInteractor.ShowPoints();
            Console.Clear();
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
                        goalInteractor.GoalChoice();
                        break;
                    case 2:
                        goalInteractor.ListAllGoals();
                        Console.Write("Press any key to continue ");
                        Console.ReadLine();
                        break;
                    case 3:
                        goalInteractor.Save();
                        break;
                    case 4:
                        goalInteractor.Load();
                        Console.Read();
                        break;
                    case 5:
                        goalInteractor.SetDoneGoalEnumerator();
                        Console.Write("Press any key to continue ");
                        Console.ReadLine();
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
        while(choice != 6);
    }
}