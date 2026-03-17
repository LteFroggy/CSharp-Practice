using System;

namespace Q1_2 {
    internal class Repository : IRepository {
        public void Get() {
            Console.WriteLine($"데이터를 가져옵니다.");
        }
    }
}
