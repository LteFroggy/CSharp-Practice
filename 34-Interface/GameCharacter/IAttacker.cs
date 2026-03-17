namespace GameCharacter {
    internal interface IAttacker {
        int AttackPower { get; }
        void Attack(IDefender target);
    }
}
