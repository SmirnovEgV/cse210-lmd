class CompoundGoal : Goal 
{
    private bool _isDone;
    private int _requiredCompletions;
    private int _completionsCounter;
    private int _bonusPoints;
    public CompoundGoal(string name, string description, int points, int requiredCompletions, int bonusPoints) : base(name, description, points)
    {
        _isDone = false;
        _requiredCompletions = requiredCompletions;
        _bonusPoints = bonusPoints;
        _completionsCounter = 0;
        
    }
    public override void SetDone(Goal goal)
    {
        if(_completionsCounter < _requiredCompletions)
        {
            _completionsCounter++ ; 
        }
        else
        {
            CheckForCompletion();
        }

    }
    public override CompoundGoal CreateGoal()
    {
        Console.WriteLine("Input the name for a Compound Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for a Compound Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many times will it take to complete this goal?");
        int requiredCompletions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points would you want on each completion");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("What amount of bonus points would you like on the final completion of a goal?");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new CompoundGoal(name, description, points, requiredCompletions, bonusPoints);
    }
    public override int GetPoints(Goal goal)
    {
        return _goalPoints;
    }

    private void CheckForCompletion()
    {
        _isDone = true;
        _goalPoints += _bonusPoints;
    }

}