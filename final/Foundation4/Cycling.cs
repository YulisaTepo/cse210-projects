public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double lengthOperation = _length / 60.0;
        double distance = lengthOperation * _speed;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = _length / GetDistance();
        return pace;
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $": Distance {GetDistance():N2} km, Speed: {_speed} kph, Pace {GetPace()} min per km";
    }
}