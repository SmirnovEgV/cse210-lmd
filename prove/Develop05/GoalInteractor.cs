class GoalInteractor 
{ 
    List<Goal> _goals = new List<Goal>();
    SaveAndLoad _saveAndLoad = new SaveAndLoad();
    private int _totalPoints = 0;
    

    public Goal ChooseGoalToComplete()
    {
        return null;
    }

    public void Save()
    {
        string _stringpoints = _totalPoints.ToString();
        string _filename = _saveAndLoad.PromptForFileName();
        _saveAndLoad.WriteGoalsToCsv(_filename,_goals,_stringpoints);
    }
    public void Load()
    {
        string _filename = _saveAndLoad.PromptForFileName();
        _totalPoints = _saveAndLoad.RetrunTotalPoints(_filename);
        _goals = _saveAndLoad.LoadGoalsFromCsv(_filename);
    }
    public void ListAllGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }

    public int ShowPoints()
    {

        foreach (Goal goal in _goals)
        {
            _totalPoints += goal.GetPoints(goal);
        }

        return _totalPoints;
    }

    public void SetDoneGoalEnumerator()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
        
        Console.Write("Enter the number of the item you want to set: ");
        if (int.TryParse(Console.ReadLine(), out int selected))
        {
        
            if (selected >= 1 && selected <= _goals.Count)
            {
                
                Goal selectedGoal = _goals[selected - 1];             
                selectedGoal.SetDone(_goals[selected - 1]);
                Console.WriteLine("You've recorded the goal");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }


    public void GoalChoice()
    {
        int choice = 0;

        GoalCreator goalCreator = new GoalCreator();
        do
        {
        Console.Clear();
        Console.WriteLine("Select a Goal type to set: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Compound Goal");
        Console.WriteLine("\t4. Negative Goal");
        Console.WriteLine("\t5. Return");
            if(int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        SimpleGoal simpleGoal = goalCreator.CreateSimpleGoal();
                        _goals.Add(simpleGoal);
                        break;
                    case 2:
                        Console.Clear();
                        EternalGoal eternalGoal = goalCreator.CreateEternalGoal();
                        _goals.Add(eternalGoal);
                        break;
                    case 3:
                        Console.Clear();
                        CompoundGoal compoundGoal = goalCreator.CreateCompoundGoal();
                        _goals.Add(compoundGoal);
                        break;
                     case 4:
                        Console.Clear();
                        NegativeSimpleGoal negativeSimpleGoal = goalCreator.CreateNegativeGoal();
                        _goals.Add(negativeSimpleGoal);
                        Console.WriteLine("\t4. Return");
                        break;
                    default:
                        Console.WriteLine("\n Not an option. Choose from options above and input a number");
                        break;
                }
            }
        }
        while (choice != 5);
    }
}
       
