class Square : Shape
{
    private int _side;
    public Square(string color, int side) : base(color)
    {
        this._side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}