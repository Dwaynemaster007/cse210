namespace Homework;

public class Assignment
{
    private string _StudentName;
    private string _topic;
    
    public Assignment(string studentName, string topic)
    {
        _StudentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _StudentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_StudentName} - {_topic}";
    }
}