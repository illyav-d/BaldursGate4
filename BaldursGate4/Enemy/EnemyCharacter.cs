using BaldursGate4.Factory;
using BaldursGate4.Logger;
using BaldursGate4.Weapon;

namespace BaldursGate4.Enemy
{
    public class EnemyCharacter : IEnemy
    {
        protected Random _random = new Random();
        protected ConsoleLogger _logger = new ConsoleLogger();

        public EnemyCharacter()
        {
            this.GenerateWeaponDrop();
            this.Hitpoints = 70;
            this.MinDamage = 1;
            this.MaxDamage = 1;
        }

        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public IWeapon WeaponDrop { get; set; }



        public IWeapon DropWeapon()
        {
            return this.WeaponDrop;
        }

        public bool ChanceToDropLoot()
        {
            int dropChance = _random.Next(1, 101);

            if (dropChance <= 33)
            {
                _logger.DisplayMessage($"Your enemy has dropped his {WeaponDrop.Name}.{Environment.NewLine}You try to pick up this weapon.");
                return true;
            }
            else
            {
                _logger.DisplayMessage("Nothing dropped.");
                return false;
            }
        }

        public virtual int MonsterAttack()
        {
            int damage = 0;

            if (this.Hitpoints > 0)
            {
                damage = _random.Next(this.MinDamage, this.MaxDamage + 1);

                _logger.DisplayMessage($"The enemy deals {damage} damage.");
            }

            return damage;
        }

        public virtual void TakeDamage(int damage)
        {
            this.Hitpoints -= damage;
            _logger.DisplayMessage($"The enemy takes {damage} damage.");

            if (this.Hitpoints <= 0)
            {
                _logger.DisplayMessage($"The enemy {this.Name} dies.");
                this.DropWeapon();
            }
            else
            {
                _logger.DisplayMessage($"The enemy has {this.Hitpoints} hitpoints left.");
            }
        }

        public void GenerateWeaponDrop()
        {
            var weaponsCount = Enum.GetNames(typeof(Weapons)).Length + 1;
            Weapons weaponName = (Weapons)_random.Next(1, weaponsCount);
            WeaponCreator weaponCreator = new WeaponCreator();
            WeaponDrop = weaponCreator.Create(weaponName);
        }
    }
}
