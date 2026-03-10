using System;
using System.Collections.Generic;
using System.Text;

namespace A11 {
    class Counter {
        private int _count;
        public int Count { 
            get => _count;
            set => _count = value;
        }

        public void Increase() => _count++;
    }
}
