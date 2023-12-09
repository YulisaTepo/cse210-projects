public class Activity
{
    private string _date;
    protected int _length;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min)";
    }
}