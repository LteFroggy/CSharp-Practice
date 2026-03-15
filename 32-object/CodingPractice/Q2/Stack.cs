namespace CodingPractice.Q2 {
    internal class Stack {
        object[] stack = null;
        private int _count;

        public Stack(int size = 10) {
            stack = new object[size];
            _count = 0;
        }

        public void Push(object o) {
            if (_count == stack.Length) { return; }
            else { stack[_count++] = o; }
        }
        public object Pop() {
            if (_count == 0) {
                return null; 
            } else { 
                return stack[--_count];
            }
        }
    }
}
