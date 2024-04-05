public class RunningExercise : Exercise
{
    private double _distance;

    public RunningExercise(int length, DateTime date, string type, double distance) : base(length, date, type)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double timeInHours = _length / 60.0; // Convert minutes to hours
        return _distance / timeInHours;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }
}