public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetFractionString()
    {
        Console.WriteLine(_top +"/"+ _bottom);
    }
    public double GetDecimalValue()
    {
        double division;
        division = (double)_top / _bottom;
        return division;
    }
}