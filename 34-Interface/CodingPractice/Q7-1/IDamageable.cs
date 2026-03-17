namespace Q7_1 {
    internal interface IDamageable {
        int Health { get; }
        void TakeDamage(int damage);
    }
}
