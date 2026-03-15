using System;
using System.Runtime.Serialization;

namespace GameItem {
    internal class Inventory {
        private Item[] items;
        private int _count;
        public Inventory(int size = 10) {
            items = new Item[size];
            _count = 0;
        }

        public void AddItem(Item item) {
            items[_count++] = item;
        }

        public void ShowInventory() {
            for (int i = 0; i < _count; i++) {
                Console.WriteLine($"슬롯 {i + 1} : {items[i]}");
            }
        }
    }
}
