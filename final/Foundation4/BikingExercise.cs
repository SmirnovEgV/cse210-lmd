public class BikingExercise : Exercise
{
    private int _speed;

    public BikingExercise(int length, DateTime date, string type, int speed) : base(length,date,type)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double timeInHours = _length / 60.0;
        return _speed * timeInHours;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

}