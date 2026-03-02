using System;
class ScoreTracker {
    private const int MaxScore = 100;
    private const int MinScore = 0;
    private readonly string _subjectName;
    private int _score;
    private int _bonusCount;
    
    public ScoreTracker(string name) {
        _subjectName = name;
    }

    public void SetScore(int score) {
       if (score < MinScore || score > MaxScore) {
            Console.WriteLine($"점수는 {MinScore} ~ {MaxScore} 사이여야 합니다.");
       } else {
            _score = score;
            Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
        }
    }
    
    public void AddBonus(int bonus) {
        _bonusCount++;
        Console.Write($"{bonus}점 보너스 적용! ");
        if (bonus + _score > MaxScore) {
            _score = MaxScore;
        } else {
            _score += bonus;
        }
        Console.WriteLine($"현재 점수 : {_score}점 {(_score == MaxScore ? "(최대 점수 도달)" : "")}");
    }
    public void ShowScore() {
        Console.WriteLine($"=== {_subjectName} ===");
        Console.WriteLine($"점수 : {_score} / {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수 : {_bonusCount}");
    }
}