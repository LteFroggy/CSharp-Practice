using System;

namespace CodingPractice.Q8_1 {
    internal class Circle : Shape {
        private int _radius;
        public Circle(int radius) {
            _radius = radius;
        }

        public override double GetArea() {
            return _radius * _radius * Math.PI;
        }
    }
}
