public class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    public virtual void SetDone()
    {

    }
    public virtual void CreateGoal()
    {
        
    }
    public virtual void GetPoints()
    {
        
    }

}