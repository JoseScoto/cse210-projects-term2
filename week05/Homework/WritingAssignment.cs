// Inherits from Assignment class
public class WritingAssignment : Assignment
{
    // Adds the title property
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method
    public string GetWritingInformation()
    {
        // Using the GetStudentName method from the base class
        return $"{_title} by {GetStudentName()}";
    }
}