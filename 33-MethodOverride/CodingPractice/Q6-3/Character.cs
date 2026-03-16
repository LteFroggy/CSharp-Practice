namespace Q6_3 {
    internal class Character {
        public Character(string name, int level, int health) {
            Name = name;
            Level = level;
            Health = health;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public override string ToString() {
            return $"[{Name}] Lv.{Level} HP : {Health}";
        }
    }
}
