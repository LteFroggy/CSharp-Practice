using System;
using System.Collections;
using System.Collections.Generic;

class Nickname {
    private Dictionary<string, string> _dict = new Dictionary<string, string>();
    public string this[string key] {
        get => _dict[key].ToString();
        set => _dict[key] = value;
    }
}