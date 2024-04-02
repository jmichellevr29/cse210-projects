public class Rectangle : Shape
{
    private double _lenghth;
    private double _width;
    public Rectangle(string color, double length, double width)
        : base (color)
    {
        _lenghth = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _lenghth * _width;
    }
}