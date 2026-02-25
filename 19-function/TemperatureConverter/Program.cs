using System;
class DegreeConverter {
    public double ToFahrenheit(double celcious) => (celcious * 9.0 / 5.0) + 32;
    public double ToCelcious(double fahrenheit) => (fahrenheit - 32) * 5.0 / 9.0;
}
class Program {
    public static void Main(string[] args) {
        int celcious, fahrenheit;
        DegreeConverter degreeConverter = new DegreeConverter();
        Console.WriteLine($"=== 온도 변환기 ===");
        Console.WriteLine();
        Console.WriteLine($"[섭씨 -> 화씨]");
        celcious = 5;
        Console.WriteLine($"{celcious, 3}°C = {degreeConverter.ToFahrenheit(celcious):F1}°F");
        celcious = 25;
        Console.WriteLine($"{celcious, 3}°C = {degreeConverter.ToFahrenheit(celcious):F1}°F");
        celcious = 100;
        Console.WriteLine($"{celcious, 3}°C = {degreeConverter.ToFahrenheit(celcious):F1}°F");
        Console.WriteLine();

        Console.WriteLine($"[화씨 -> 섭씨]");
        fahrenheit = 32;
        Console.WriteLine($"{fahrenheit, 3}°F = {degreeConverter.ToCelcious(fahrenheit):F1}°C");
        fahrenheit = 77;
        Console.WriteLine($"{fahrenheit, 3}°F = {degreeConverter.ToCelcious(fahrenheit):F1}°C");
        fahrenheit = 212;
        Console.WriteLine($"{fahrenheit, 3}°F = {degreeConverter.ToCelcious(fahrenheit):F1}°C");
        Console.WriteLine();
        Console.WriteLine();
    }
}