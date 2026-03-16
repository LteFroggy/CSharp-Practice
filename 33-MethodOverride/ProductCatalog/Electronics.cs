using System;
using System.Threading.Channels;

namespace ProductCatalog {
    internal class Electronics : Product {
        public int Warranty { get; set; }
        public Electronics(string name, int price, int warranty = 24) : base(name, price) {
            Warranty = warranty;
        }

        public override string ToString() {
            return base.ToString() + $" (보증 : {Warranty}개월)"; 
        }

        public override string GetDescription() {
            return $"전자기기입니다. 취급에 주의하세요.";
        }
    }
}
