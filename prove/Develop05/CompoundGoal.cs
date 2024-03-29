class CompoundGoal : Goal 
{
    private bool _isDone;
    private int _requiredCompletions;
    private int _completionsCounter;
    private int _bonusPoints;
    private int someCounter = 1;
    private string status = "";

    public CompoundGoal(string name, string description, int points, int requiredCompletions, int bonusPoints) : base(name, description, points)
    {
        _isDone = false;
        _requiredCompletions = requiredCompletions;
        _bonusPoints = bonusPoints;
        _completionsCounter = 0;  
    }

    public CompoundGoal(string name, string description, int points, int requiredCompletions,int completionsDone, int bonusPoints) : base(name, description, points)
    {
        _isDone = false;
        _requiredCompletions = requiredCompletions;
        _bonusPoints = bonusPoints;
        _completionsCounter = completionsDone;  
    }

    public override void SetDone(Goal goal)
    {
        if(_completionsCounter != _requiredCompletions)
        {
            _completionsCounter++ ; 
        }
        if(_completionsCounter == _requiredCompletions)
        {
            CheckForCompletion();
        }

    }

    public override int GetPoints(Goal goal)
    {
        if(_completionsCounter == someCounter)
        {
            someCounter ++;
            return _goalPoints;
        }
        else
        {
           return 0; 
        }
        
    }

    private void CheckForCompletion()
    {
        _isDone = true;
        _goalPoints += _bonusPoints;
        status = "X";
    }
    public override string ToString()
    {
        // Provide a string representation of EternalGoal object
        return $"[{status}] Compound Goal: Name - {_goalName}, description - {_goalDescription}, points per completion - {_goalPoints}, completions {_completionsCounter}/{_requiredCompletions}";
    }
    public override string GetConvertedString()
    {
        return $"{_goalName}/{_goalDescription}/{_goalPoints}/{_completionsCounter}/{_requiredCompletions}/{_bonusPoints}/{_isDone}";
    }

}