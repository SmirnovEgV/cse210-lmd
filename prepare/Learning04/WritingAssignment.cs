public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentNamePassing, string topic, string title) : base(studentNamePassing, topic)
    {
        _title = title;
    }

public string GetWritingInformation(){
    return $"{_title} by {studentName}";
}

}