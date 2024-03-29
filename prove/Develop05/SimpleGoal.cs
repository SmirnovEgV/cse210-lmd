class SimpleGoal : Goal
{
    private string status = "";
    private bool _isDone;
    private int counter = 0;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
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
            return _goalPoints;
        }
        else{
            return 0;
        }
        
    }
    public override string ToString()
    {
        // Provide a string representation of EternalGoal object
        return $"[{status}] Simple Goal: Name - {_goalName}, description -{_goalDescription}, poinst - {_goalPoints}";
    }
    public override string GetConvertedString()
    {
        return $"{_goalName}/{_goalDescription}/{_goalPoints}/{_isDone}";
    }

}