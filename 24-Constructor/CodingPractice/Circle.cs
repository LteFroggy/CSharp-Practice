using System;

class Circle {
    private int _radius;
    public Circle(int radius) {
        _radius = radius;
    }
    public double GetArea() {
        return _radius * _radius * Math.PI;
    }
}