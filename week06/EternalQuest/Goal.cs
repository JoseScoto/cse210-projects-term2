public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Add getters for the protected fields
    public string GetName()
    {
        return _shortName;
    }

    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}