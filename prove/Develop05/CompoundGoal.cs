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
    public override void SetDone()
    {
        base.SetDone();
    }
    public override void CreateGoal()
    {
        base.CreateGoal();
    }
    public override void GetPoints()
    {
        base.GetPoints();
    }

    private void CheckForCompletion()
    {
        
    }

}