class GoalInteractor 
{ 
    List<Goal> _goals = new List<Goal>();

    public Goal ChooseGoalToComplete()
    {
        return null;
    }
    public void ListAllGoals()
    {
        foreach (Goal _goal in _goals)
        {
            Console.WriteLine(_goal);
        }
    }

    public void GoalChoice()
    {
        int choice = 0;
        Console.Write("Select a Goal type to set: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Compound Goal");
            if(int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\t1. Simple Goal");
                        break;
                    case 2:
                        Console.WriteLine("\t2. Eternal Goal");
                        // list things that where created originally
                        break;
                    case 3:
                        Console.WriteLine("\t3. Compound Goal");
                        // Save things to a txt file
                        break;
                     case 4:
                        // load things from txt file
                        break;
                    default:
                        Console.WriteLine("\n Not an option. Choose from options above and input a number");
                        break;
                }
            }
        }
}
       
