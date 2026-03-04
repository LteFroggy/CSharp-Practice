using System;

class ShoppingCart {
    private string _storeName;
    private int _discount;
    private int _totalPrice;
    private int _itemCount;

    public ShoppingCart() : this("온라인몰") { }
    public ShoppingCart(string storeName) : this(storeName, 0) { }
    public ShoppingCart(string storeName, int discount) {
        _storeName = storeName;
        _discount = discount;
        _totalPrice = 0;
        _itemCount = 0;
    }

    public void AddItem(string itemName, int price) {
        _totalPrice += price;
        _itemCount++;

        Console.WriteLine($"[{itemName}] 추가 ({_totalPrice}원)");
    }

    private double GetFinalPrice() => (double)_totalPrice * (100 - _discount) / 100;

    public void PrintInfo() {
        Console.WriteLine($"[{_storeName}] 아이템 {_itemCount}개, 합계 {_totalPrice:N0}원, 할인 적용 {GetFinalPrice():N0}원");
    }
}