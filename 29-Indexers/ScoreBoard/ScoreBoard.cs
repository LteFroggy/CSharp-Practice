using System;
using System.Collections.Generic;
using System.Text;

class ScoreBoard {
    private string[] _names;
    private int[] _scores;
    private int _count;

    public int Count { get { return _count; } }

    public string this[int idx] {
        get {
            if (idx < 0 || idx >= _count) { return ""; }
            else { return _names[idx]; }
        }
    }
    
    public int this[string name] {
        get {
            for (int i = 0; i < _count; i++) {
                if (_names[i] == name) { return _scores[i]; }
            }
            return -1;
        } set {
            for (int i = 0; i < _count; i++) {
                if (_names[i] == name) { 
                    _scores[i] = value;
                    break;
                }
            }
        }
    }

    public ScoreBoard(int capacity) {
        _names = new string[capacity];
        _scores = new int[capacity];
        _count = 0;
    }

    public void ShowInfo() {
        for (int i = 0; i < _count; i++) {
            Console.WriteLine($"{i + 1}번 : {_names[i]}");
        }
    }

    public void Register(string name, int score) {
        if (_count > _names.Length - 1) {
            Console.WriteLine($"성적표가 가득 찼습니다");
        } else {
            _names[_count] = name;
            _scores[_count++] = score;
        }
    }

    
}