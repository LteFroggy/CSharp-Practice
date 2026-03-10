using System;
using System.Net.Http;

namespace A8 {
    class Page {
        public string Message { get; private set; } = "읽기 전용 메세지";
        public void UpdateMessage(string message) {
            Message = message;
        }
    }
}
