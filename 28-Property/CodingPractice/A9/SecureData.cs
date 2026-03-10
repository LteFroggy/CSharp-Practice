using System;

namespace A9 {
    class SecureData {
        private string _password;
        public SecureData(string password) {
            _password = password;
        }

        public string Password { set { _password = value; } }
        
        public bool Validate(string password) => _password == password;

    }
}
