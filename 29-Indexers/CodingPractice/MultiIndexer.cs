using System;
using System.Collections;

class MultiIndexer {
    private Hashtable _hash = new Hashtable();

    public string this[int idx] {
        get => _hash[idx].ToString();
        set => _hash[idx] = value;
    }

    public string this[string key] {
        get => _hash[key].ToString();
        set => _hash[key] = value;
    }
}