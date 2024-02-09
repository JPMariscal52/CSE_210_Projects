

using System.Formats.Asn1;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color): base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double squareArea = _side * _side;
        return squareArea;
    }
}