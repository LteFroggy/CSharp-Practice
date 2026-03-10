using System;

class Student {
    private string _name;
    private int _koreanScore;
    private int _englishScore;
    private int _mathScore;

    public string Name { get => _name; }
    public int KoreanScore { get => _koreanScore; set => _koreanScore = Math.Clamp(value, 0, 100); }
    public int EnglishScore { get => _englishScore; set => _englishScore = Math.Clamp(value, 0, 100); }
    public int MathScore { get => _mathScore; set => _mathScore = Math.Clamp(value, 0, 100); }

    public int TotalScore { get => _koreanScore + _englishScore + _mathScore; }
    public double Average { get => (double)TotalScore / 3;}
    public char Grade {
        get {
            switch ((int)(Average) / 10) {
                case 10:
                case 9:
                    return 'A';
                case 8:
                    return 'B';
                case 7:
                    return 'C';
                case 6: 
                    return 'D';
                default :
                    return 'F';
            }
        }
    }

    public Student(string name) {
        _name = name;
    }
}