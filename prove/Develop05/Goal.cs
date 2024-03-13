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

    public virtual void SetDone(Goal goal)
    {
        
    }
    public virtual Goal CreateGoal()
    {
        return null;   
    }
    public virtual int GetPoints(Goal goal)
    {
        return _goalPoints;
    }

}