class Simple : Goal
{
    protected bool _isComplete = false;
    public Simple(string name, string description, int points) : base(name, description, points)
    {
    }

    public Simple(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base.RecordEvent();
    }
    public override string DisplayString()
    {

        string cross = " ";
        if (_isComplete == true)
        {
            cross = "X";
        }
        return $"[{cross}] {_name} ({_description})";
    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name}|{_name}|{_description}|{_points}|{_isComplete}";
    }
}