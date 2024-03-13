class SimpleGoal : Goal
{

    private bool _isDone;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isDone = false;
        
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

}