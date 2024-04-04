public class Video
{
    private string _name;
    private string _author;
    private double _length;
    private List<Commentary> _comments;

    public Video(string name, string author, double length)
    {
        _name = name;
        _author = author;
        _length = length;
        _comments = new List<Commentary>();
    }

    public void AddComments(Commentary commentary)
    {
        // Console.Write("Enter commenter name: ");
        // string name = Console.ReadLine();
        // Console.Write("Enter commentary text: ");
        // string text = Console.ReadLine();
        // Commentary comment =  new Commentary(name, text);
        _comments.Add(commentary);
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"'{_name}' -- BY: {_author} || {_length} :minutes");
        Console.WriteLine($"Comments - {_comments.Count}");
        foreach (var comment in _comments)
        {
            comment.Print();
        }
    }
}