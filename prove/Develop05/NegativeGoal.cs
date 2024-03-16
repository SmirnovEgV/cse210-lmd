class NegativeSimpleGoal : Goal
{
    private string status = "";
    private bool _isDone;
    private int counter = 0;

    public NegativeSimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isDone = false;
    }

    public override void SetDone(Goal goal)
    {
        _isDone = true;
        status = "X";
    }
    
    public override int GetPoints(Goal goal)
    {
        if (_isDone == true && counter == 0)
        {
            counter = 1;
            return -_goalPoints; // Return negative points
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        // Provide a string representation of NegativeSimpleGoal object
        return $"[{status}] Negative Simple Goal: Name - {_goalName}, description -{_goalDescription}, points - {_goalPoints}";
    }
}
