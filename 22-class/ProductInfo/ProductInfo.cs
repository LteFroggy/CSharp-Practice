using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInfo {
    internal class ProductInfo {
        public int _discountPercent;
        public string Name { get; set; }
        public int Price { get; set; }
        public int DiscountPercent {
            get => _discountPercent;
            set {
                if (value >= 0 && value <= 100) {
                    _discountPercent = value;    
                } else { return; }
            }
        }
        public int DiscountAmount => Price * DiscountPercent / 100;
        public int FinalPrice => Price - DiscountAmount;

        public ProductInfo(string name, int price) {
            Name = name;
            Price = price;
            DiscountPercent = 0;
        }
        public ProductInfo(string name, int price, int discountPercent) {
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }

        public void PrintInfo() {
            Console.WriteLine($"[상품 정보] {Name} - 가격 : {Price:N0}원, 할인 : {DiscountPercent}% (-{DiscountAmount:N0}원), 최종가 : {FinalPrice:N0}원");
        }
    }
}
