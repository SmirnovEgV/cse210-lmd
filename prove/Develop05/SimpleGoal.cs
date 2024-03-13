class SimpleGoal : Goal
{

    private bool _isDone;

    public SimpleGoal() : base("","",0)
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