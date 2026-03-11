using System;
using System.Collections.Generic;
using System.Text;

class Example {
    private string _name;
    private string[] _strArr;

    public string Name { get => _name; set => _name = value; }

    public Example() {
        _strArr = new String[2];
        _strArr[0] = "첫 번째";
        _strArr[1] = "두 번째";
    }

    public string this[int idx] {
        get => _strArr[idx];
    }

}