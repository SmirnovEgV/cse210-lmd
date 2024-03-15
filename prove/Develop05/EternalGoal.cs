class EternalGoal : Goal
{
    private string status = "";
    private int counter = 0;
    private int pointsReturend = 0;
    
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void SetDone(Goal goal)
    {
        counter ++;
        pointsReturend += _goalPoints;
    }
   
    public override int GetPoints(Goal goal)
    {
        if(counter == 0)
        {
            return pointsReturend;
        }
        else
        {
            return pointsReturend;
        }
    }
    public override string ToString()
    {
        // Provide a string representation of EternalGoal object
        return $"[{status}] Eternal Goal: Name - {_goalName}, description - {_goalDescription}, points - {_goalPoints}";
    }
}