using System;
using System.Collections.Generic;
using System.Text;

namespace A13 {
    class Player {
        public string Name  { get; set; }
        public int BirthYear { get; set; }
        public int Age { get => DateTime.Now.Year -  BirthYear; }
    }
}
