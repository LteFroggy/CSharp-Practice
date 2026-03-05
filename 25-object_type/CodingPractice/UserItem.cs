using System;
class UserItem {
    private string _name;
    private int _price;

    public UserItem(string name, int price) {
        _name = name;
        _price = price;
    }

    public override string ToString() {
        return $"{_name} : {_price:N0}골드";
    }

}