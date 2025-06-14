using System;

public class Circle: Shape
{
    private float _radius;

    public Circle(float radius, string color): base(color)
    {
        _radius = radius;
    }

    public override float GetArea() {
        float pi = (float)Math.PI;
        return pi * _radius * _radius;
    }
}