using System;

namespace ProductCatalog {
    internal class Food : Product {
        public DateTime DateTime { get; set; }
        public Food(string name, int price, DateTime dateTime) : base(name, price) {
            DateTime = dateTime;
        }

        public override string ToString() {
            return base.ToString() + $" (유통기한 : {DateTime})";
        }

        public override string GetDescription() {
            return $"식품입니다. 냉장 보관하세요.";
        }
    }
}
