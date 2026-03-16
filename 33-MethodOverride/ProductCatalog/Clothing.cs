using System.Threading.Channels;

namespace ProductCatalog {
    internal class Clothing : Product {
        public char Size { get; set; }
        public Clothing(string name, int price, char size = 'M') : base(name, price) {
            Size = size;
        }

        public override string ToString() {
            return base.ToString() + $" (사이즈 : {Size})";
        }

        public override string GetDescription() {
            return $"의류입니다. 세탁 방법을 확인하세요.";
        }
    }
}
