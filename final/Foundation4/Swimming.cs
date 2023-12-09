using System.ComponentModel.DataAnnotations;

public class Swimming : Activity
{
    private double _laps;
    private int _lapLength = 50;
    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double distance = _laps * _lapLength / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance() / _length * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _length / GetDistance();
        return pace; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $": Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}