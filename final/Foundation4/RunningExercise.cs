public class RunningExercise : Exercise
{
    private int _distance;

    public RunningExercise(int length, DateTime date, string type, int distance) : base(length, date, type)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double timeInHours = _length / 60.0;
        double speed = _distance * timeInHours;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _distance * _length;
        return pace;
    }
}