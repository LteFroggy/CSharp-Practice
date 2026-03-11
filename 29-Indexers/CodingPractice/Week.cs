using System;
using System.Data.SqlTypes;

class Week {
    private string[] _weekArr;
    private int _length;

    public Week() : this(7) { }
    public Week(int size) {
        _length = size;
        _weekArr = new string[size];
    }

    public string this[int idx] {
        get => _weekArr[idx];
        set => _weekArr[idx] = value;
    }

    public int Length { get => _length; }
}