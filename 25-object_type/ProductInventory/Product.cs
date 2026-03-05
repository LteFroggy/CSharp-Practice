using System;
using System.Security.Cryptography.X509Certificates;

class Product {
    private string _name;
    private int _price;
    private int _stock;

    public string Name {
        get => _name;
        set => _name = value;
    }
    public int Price {
        get => _price;
        set => _price = value;
    }
    public int Stock {
        get => _stock;
        set => _stock = value;
    }

    public override string ToString() {
        return $"[{Name}] {_price:N0}원 (재고 : {_stock}개)";
    }
    
    public void Sell(int quantity) {
        if (quantity > _stock) {
            Console.WriteLine($"{_name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고 : {_stock}개)");
        } else {
            _stock -= quantity;
            Console.WriteLine($"{_name} {quantity}개 판매 완료. 남은 재고 : {_stock}개");
        }
    }

    public int GetTotalValue() => _price * _stock;

    public void AddStock(int quantity) {
        _stock += quantity;
        Console.WriteLine($"{_name} {quantity}개 재고 추가. 현재 재고 : {_stock}개");
    }
}