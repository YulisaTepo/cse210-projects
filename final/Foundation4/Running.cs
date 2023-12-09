public class Running : Activity
{
    private double _distance;
    public Running(string date, int length, double distance) : base (date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / _length * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _length / _distance;
        return pace;
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $": Distance {_distance} km, Speed: {GetSpeed()} kph, Pace {GetPace()} min per km";
    }

}