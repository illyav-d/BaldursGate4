using BaldursGate4.Weapon;

namespace BaldursGate4.Enemy
{
    public interface IEnemy
    {
        string Name { get; set; }
        int Hitpoints { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        IWeapon WeaponDrop { get; set; }

        int MonsterAttack();
        void TakeDamage(int damage);
        IWeapon DropWeapon();
        void GenerateWeaponDrop();
        public bool ChanceToDropLoot();


    }
}
