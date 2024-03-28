public class Commentary
{
    private string _name;
    private string _text;

    public Commentary(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void Print()
    {
        Console.WriteLine($"\n\t{_name}\n\t{_text}");
    }
}