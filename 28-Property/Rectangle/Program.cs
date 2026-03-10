using System;

Rectangle rec1 = new Rectangle() {
    Width = 10,
    Height = 5
};

Console.WriteLine($"=== 사각형 1 ===");
Console.WriteLine($"가로 : {rec1.Width}, 세로 : {rec1.Height}");
Console.WriteLine($"넓이 : {rec1.Area}");
Console.WriteLine($"둘레 : {rec1.Perimeter}");
Console.WriteLine($"정사각형 : {rec1.IsSquare}");

Console.WriteLine();
Console.WriteLine();

Rectangle rec2 = new Rectangle() {
    Width = 7,
    Height = 7
};
Console.WriteLine($"=== 사각형 2 ===");
Console.WriteLine($"가로 : {rec2.Width}, 세로 : {rec2.Height}");
Console.WriteLine($"넓이 : {rec2.Area}");
Console.WriteLine($"둘레 : {rec2.Perimeter}");
Console.WriteLine($"정사각형 : {rec2.IsSquare}");