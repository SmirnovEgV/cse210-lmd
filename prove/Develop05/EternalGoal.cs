class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void SetDone(Goal goal)
    {
    }
    public override EternalGoal CreateGoal()
    {
        Console.WriteLine("Input the name for an Eternal Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for an Eternal Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many points would you want on completion");
        int points = int.Parse(Console.ReadLine());
        EternalGoal eternalGoal = new EternalGoal(name,description,points);
        return eternalGoal;
    }
    public override int GetPoints(Goal goal)
    {
        return _goalPoints;
    }
}