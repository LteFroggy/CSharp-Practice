using System;
using System.Collections.Generic;
using System.Text;

namespace A10 {
    class Circle {
        public int Radius { get; set; }
        public double Area { get => Radius * Radius * Math.PI; }
        public double Circumference { get => Radius * 2 * Math.PI; }

    }
}
