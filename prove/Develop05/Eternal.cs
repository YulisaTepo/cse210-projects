class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override string DisplayString()
    {
        return $"[ ] {_name} ({_description})";
    }
}