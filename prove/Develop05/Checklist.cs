class Checklist : Goal
{
    private int _bonus;
    private int _timesToComplete;
    private int _timesCompleted;

    public Checklist(string name, string description, int points, int bonus, int timesToComplete) : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonus = bonus;

    }
    public override string DisplayString()
    {

        string cross = " ";
        if (_timesCompleted == _timesToComplete)
        {
            cross = "X";
        }
        return $"[{cross}] {_name} ({_description} -- Currently completed: {_timesCompleted}/{_timesToComplete})";

    }
    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _timesToComplete)
        {
            return _points+_bonus;
        }
        else
        {
            return _points;
        }
    }
    public override string ToSavedString()
    {
        return $"{this.GetType().Name}|{_name}|{_description}|{_points}|{_bonus}|{_timesToComplete}|{_timesCompleted}";
    }
}