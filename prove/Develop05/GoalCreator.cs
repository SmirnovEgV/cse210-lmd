class GoalCreator
{
    public GoalCreator()
    {

    }
    public CompoundGoal CreateCompoundGoal()
    {
        Console.WriteLine("\t3. Compound Goal");
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
        CompoundGoal compoundGoal = new CompoundGoal(name, description, points, requiredCompletions, bonusPoints);
        return compoundGoal;
    }
    public EternalGoal CreateEternalGoal()
    {
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("Input the name for an Eternal Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for an Eternal Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many points it will give on completion");
        int points = int.Parse(Console.ReadLine());
        EternalGoal eternalGoal = new EternalGoal(name,description,points);
        return eternalGoal;
    }
    public  SimpleGoal CreateSimpleGoal()
    {
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("Input the name for a Compound Goal");
        string name = Console.ReadLine();
        Console.WriteLine("Input the description for a Compound Goal");
        string description = Console.ReadLine();
        Console.WriteLine("How many points would you want on completion");
        int points = int.Parse(Console.ReadLine());
        SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
        return simpleGoal;
    }

}