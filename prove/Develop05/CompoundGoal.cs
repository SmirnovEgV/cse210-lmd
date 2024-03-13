class CompoundGoal : Goal 
{
    private bool _isDone;
    private int _numberOfCompletions;
    private int _completionsCounter;
    private int _bonusPoints;
    public CompoundGoal(string name, string description, int points, int numberOfCompletions, int bonusPoints) : base(name, description, points)
    {
        _isDone = false;
        _numberOfCompletions = numberOfCompletions;
        _bonusPoints = bonusPoints;
        
    }
    public override void SetDone(Goal goal)
    {

    }
    public override CompoundGoal CreateGoal()
    {
        Console.WriteLine("Input the name for a Compound Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for a Compound Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many times will it take to complete this goal?");
        int numberOfCompletions = int.Parse(Console.ReadLine()); 
        Console.WriteLine("How many points would you want on each completion");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("What amound of bonus poits would you like on final completion of a goal?");
        int bonusPoints = int.Parse(Console.ReadLine());

        CompoundGoal compoundGoal = new CompoundGoal(name,description,points,numberOfCompletions,bonusPoints);
        return compoundGoal;
    }
    public override int GetPoints(Goal goal)
    {
        return _goalPoints;
    }

    private void CheckForCompletion()
    {
        
    }

}