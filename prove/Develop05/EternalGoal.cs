class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
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