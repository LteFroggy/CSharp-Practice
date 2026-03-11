using System;

class FruitPriceList {
    private string[] _names;
    private int[] _prices;
    private int _count;
    private int _capacity;

    public int Count { get { return _count; } }

    public int this[string name] {
        get {
            for (int i = 0; i < _count; i++) {
                if ( _names[i] == name) { return _prices[i]; }
            }

            return -1;
        } 
    }
    public string this[int idx] {
        get => _names[idx];
    }

    public FruitPriceList(int capacity) {
        _capacity = capacity;
        _names = new string[capacity];
        _prices = new int[capacity];
        _count = 0;
    }


    public void Add(string name, int price) {
        if (_count < _capacity - 1) {
            _names[_count] = name;
            _prices[_count++] = price;
        } else {
            Console.WriteLine($"가격표가 가득 찼습니다.");
        }
    }

    public void GetList() {
        for (int i = 0; i < _count; i++) {
            Console.WriteLine($"{i + 1}번 : {_names[i]}");
        }
    }
}