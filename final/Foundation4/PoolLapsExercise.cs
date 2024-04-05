public class PoolLapsExercise : Exercise
{
    private int _numberOfLaps;

    public PoolLapsExercise(int length, DateTime date, string type, int numberOfLaps) : base(length,date,type)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        double swimingDistance = _numberOfLaps * 50 / 1000;
        return swimingDistance;
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        double speed = distance / _length * 60;
        return speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance / _length;
    }

}