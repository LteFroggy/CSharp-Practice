namespace CodingPractice.Q8_1 {
    internal class Rectangle : Shape {
        private int _width;
        private int _height;
        public Rectangle(int width, int height) {
            _width = width;
            _height = height;
        }

        public override double GetArea() {
            return (double)_width * _height;
        }
    }
}
