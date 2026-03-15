using static System.Net.Mime.MediaTypeNames;

namespace GameItem {
    abstract internal class Item {
        protected Item(string name, int price) {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString() {
            return "";
        }
    }
}
