public class Assignment
{
    // Properties
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
    // This is the method that allows derived classes access the student name
    public string GetStudentName()
    {
        return _studentName;
    }
}