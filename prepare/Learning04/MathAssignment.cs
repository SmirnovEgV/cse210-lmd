public class MathAssignmetn : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignmetn(string studentNamePassing, string topic, string textbookSection, string problems) : base(studentNamePassing, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}
