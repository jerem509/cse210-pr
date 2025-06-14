using System;

public class Rectangle: Shape
{
    private float _width;
    private float _length;

    public Rectangle(float width, float length, string color): base(color)
    {
        _width = width;
        _length = length;
    }

    public override float GetArea()
    {
        return _width * _length;
    }
}