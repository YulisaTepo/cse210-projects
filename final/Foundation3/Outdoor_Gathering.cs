public class Outdoor_Gathering : Event
{
    private string _weatherForecast;

    public Outdoor_Gathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weatherForecast = weather;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather: {_weatherForecast}";
    }
}