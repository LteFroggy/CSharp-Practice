namespace Q6_2 {
    internal class Person {
        public string Name { get; set; }

        public Person(string name) { this.Name = name; }

        public override string ToString() {
            return $"[ Person클래스 : {Name} ]";
 
        }
    }
}
