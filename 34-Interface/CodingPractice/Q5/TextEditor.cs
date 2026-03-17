using System;

namespace Q5 {
    internal class TextEditor : IRedoable {
        public void Undo() {
            Console.WriteLine($"실행 취소");
        }
        public void Redo() {
            Console.WriteLine($"다시 실행");
        }
    }
}
