using System;

class Rectangle {
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int Area => Width * Height;
    public int Perimeter => (Width * 2) + (Height * 2);
    public bool IsSquare => Width == Height;
}