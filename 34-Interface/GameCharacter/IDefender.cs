using System.Dynamic;

namespace GameCharacter {
    internal interface IDefender {
        int CurrentHp { get; }
        int MaxHp { get; }
        bool isDead { get; }
        void TakeDamage (int damage);
        string Name { get; }
    }
}
