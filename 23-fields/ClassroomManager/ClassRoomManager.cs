using System;
class ClassRoomManager {
    private const int MaxStudents = 5;
    private readonly string _className;
    private string[] _studentList;
    private int _studentCount;
    private static int _classRoomCount;

    public ClassRoomManager(string className) {
        _className = className;
        _studentList = new string[MaxStudents];
        _classRoomCount++;
    }
    public void AddStudent(string name) {
        if (_studentCount == MaxStudents) {
            Console.WriteLine($"정원이 초과되었습니다.");
        } else {
            _studentList[_studentCount++] = name;
        }
    }
    public void ShowStudents() {
        Console.WriteLine($"=== {_className} 학생 목록 ({_studentCount}/{MaxStudents} ===");
        for (int i = 0; i <  _studentCount; i++) {
            Console.WriteLine($"{i + 1} : {_studentList[i]}");
        }
    }
    public static void ShowTotalClassrooms() {
        Console.WriteLine($"전체 교실 수 : {_classRoomCount}");
    }
}