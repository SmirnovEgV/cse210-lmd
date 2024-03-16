class NegativeSimpleGoal : Goal
{
    private string status = "";
    private bool _isDone;
    private int _counter = 0;
    public string _goalConvertedToString;

    public NegativeSimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isDone = false;
        _goalConvertedToString = $"{name}/{description}/{points}";
    }

    public override void SetDone(Goal goal)
    {
        _isDone = true;
        status = "X";
    }
    
    public override int GetPoints(Goal goal)
    {
        if (_isDone == true && _counter == 0)
        {
            _counter = 1;
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
    public override string GetConvertedString()
    {
        return $"{_goalName}/{_goalDescription}/{_goalPoints}/{_isDone}";
    }
}
