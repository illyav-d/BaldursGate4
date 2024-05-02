using GitGate4.Factory;
using GitGate4.Logger;
using GitGate4.Weapon;

namespace GitGate4.Enemy
{
    public interface IEnemy
    {
        string Name { get; set; }
        int Hitpoints { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        IWeapon WeaponDrop { get; set; }

        int MonsterAttack(IConsoleLogger logger);
        void TakeDamage(int damage, IConsoleLogger logger);
        IWeapon DropWeapon();
        void GenerateWeaponDrop(IWeaponCreator weaponCreator);
        public bool ChanceToDropLoot(IConsoleLogger logger);


    }
}
