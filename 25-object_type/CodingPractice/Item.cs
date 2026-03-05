using System;

class Item {
    private string _name;
    private int _price;
    public Item(string name, int price) {
        _name = name;
        _price = price;
    }
}

class Item2 {
    private string _name;
    private int _price;
    public Item2(string name, int price) {
        _name = name;
        _price = price;
    }

    public override string ToString() {
        return $"아이템 {_name} - {_price:N0}골드";
    }
}