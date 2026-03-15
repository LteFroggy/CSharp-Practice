namespace CodingPractice.Q7_2 {
    internal class GenericStack<T> {
        private T[] stack;
        private int _count;
        public GenericStack(int size = 10) {
            stack = new T[size];
            _count = 0;
        }

        public void Push(T val) {
            if (_count == stack.Length) return;
            stack[_count++] = val;
        }

        public T Pop() {
            return stack[--_count];
        }
    }
}
