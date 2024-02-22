public class Assignment 
{
    protected string studentName; 
    private string _topic;

    public Assignment(string studentNamePassing, string topic)
    {
        studentName = studentNamePassing;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{studentName} -- {_topic}";
    }

}