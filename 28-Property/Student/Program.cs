using System;

Student[] students = new Student[3];

students[0] = new Student("김철수") {
    KoreanScore = 85,
    EnglishScore = 90,
    MathScore = 95
};

students[1] = new Student("이영희") {
    KoreanScore = 75,
    EnglishScore = 80,
    MathScore = 70
};

students[2] = new Student("박민수") {
    KoreanScore = 100,
    EnglishScore = 100,
    MathScore = 0
};

foreach (Student s in students) {
    Console.WriteLine($"=== 성적표 : {s.Name}");
    Console.WriteLine($"국어 : {s.KoreanScore}, 영어 : {s.EnglishScore}, 수학 : {s.MathScore}");
    Console.WriteLine($"총점 : {s.TotalScore}");
    Console.WriteLine($"평균 : {s.Average:F2}");
    Console.WriteLine($"학점 : {s.Grade}");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
