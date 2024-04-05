public class Exercise 
{
    protected int _length;
    protected DateTime _date;
    protected string _type;

    public Exercise(int length, DateTime date, string type)
    {
        _length = length;
        _date = date;
        _type = type;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public void GetSummary()
    {
        double distance = GetDistance();
        
        double speed = GetSpeed();
        
        double pace = GetPace();
        
        Console.WriteLine($"Date: {_date.ToString("dd MMM yyyy")}, {_type} ({_length} min),: Distance {distance} Km, Speed: {speed} KpH, Pace: {pace} min per Km");
    }
}