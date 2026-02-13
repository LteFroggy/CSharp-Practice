using System;

int score = 78;
char grade = default;

if (score >= 90) { grade = 'A'; }
else if (score >= 80) { grade = 'B'; }
else if (score >= 70) { grade = 'C'; }
else if (score >= 60) { grade = 'D'; }
else { grade = 'F'; }

Console.WriteLine($"점수 : {score}");
Console.WriteLine($"학점 : {grade}");
Console.WriteLine();
Console.WriteLine();