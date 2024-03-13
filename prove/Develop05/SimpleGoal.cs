class SimpleGoal : Goal
{

    private bool _isDone;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isDone = false;
    }

    public override void SetDone(Goal goal)
    {
        _isDone = true;
    }
    public override SimpleGoal CreateGoal()
    {
        Console.WriteLine("Input the name for a Compound Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for a Compound Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many points would you want on completion");
        int points = int.Parse(Console.ReadLine());
        SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
        return simpleGoal;
    }
    public override int GetPoints(Goal goal)
    {
        return _goalPoints;
    }

}