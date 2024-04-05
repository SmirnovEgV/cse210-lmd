public class PoolLapsExercise : Exercise
{
    private double _numberOfLaps;

    public PoolLapsExercise(int length, DateTime date, string type, double numberOfLaps) : base(length,date,type)
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
        double speed = distance / (double)_length * 60;
        return speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance / (double)_length;
    }

}