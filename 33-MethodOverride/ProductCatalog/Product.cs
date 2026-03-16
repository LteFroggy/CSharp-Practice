namespace ProductCatalog {
    internal class Product {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return $"{Name} - ₩{Price:N0}";
        }

        public virtual string GetDescription() {
            return $"Description";
        }
    }
}
