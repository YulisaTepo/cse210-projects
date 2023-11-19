public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    
    //Properties
    public string GetName()
    {
        return _name;
    }

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public void IsCompleted()
    {
        _isCompleted = true;
    }

    public abstract string DisplayString();
    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual string ToSavedString()
    {
        return $"{this.GetType().Name}|{_name}|{_description}|{_points}";
    }
}