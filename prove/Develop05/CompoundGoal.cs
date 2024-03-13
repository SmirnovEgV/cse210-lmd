class CompoundGoal : Goal 
{
    private bool _isDone;
    private int _numberOfCompletions;
    private int _completionsCounter;
    private int _bonusPoints;
    public CompoundGoal() : base("","",0)
    {
        _isDone = false;
        _numberOfCompletions = 0;
        _bonusPoints = 0;
        
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