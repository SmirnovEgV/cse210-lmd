class EternalGoal : Goal
{
    private string status = "";
    private int counterA = 0;
    private int counterB = 0;
    private int pointsReturend;
    
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void SetDone(Goal goal)
    {
        counterA ++;
        pointsReturend = _goalPoints;
    }
   
    public override int GetPoints(Goal goal)
    {
        if(counterA != counterB )
        {
            counterB ++;
            return pointsReturend;
        }
        else
        {
            return 0;
        }
    }
    public override string ToString()
    {
        // Provide a string representation of EternalGoal object
        return $"[{status}] Eternal Goal: Name - {_goalName}, description - {_goalDescription}, points - {_goalPoints}";
    }
    public override string GetConvertedString()
    {
        return $"{_goalName}/{_goalDescription}/{_goalPoints}";
    }
}