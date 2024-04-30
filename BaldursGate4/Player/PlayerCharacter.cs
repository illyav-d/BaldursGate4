using BaldursGate4.Dice;
using BaldursGate4.Logger;
using BaldursGate4.Weapon;

namespace BaldursGate4.Player
{
    public class PlayerCharacter : IPlayer
    {
        protected IDice dice;
        protected ConsoleLogger _logger = new ConsoleLogger();

        public PlayerCharacter()
        {
            Weapon = new Dagger();
            dice = new Dice.Dice();
        }

        public int Hitpoints { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public IWeapon Weapon { get; set; }

        public void DisplayStats()
        {
            _logger.DisplayMessage($"These are your current stats...{Environment.NewLine}{this.Hitpoints} HP{Environment.NewLine}{this.Strength} STR{Environment.NewLine}{this.Intelligence} INT");
        }

        public void PickupWeapon(IWeapon weapon, Weapons weaponName)
        {

            if (this.Intelligence >= weapon.MinIntelligence && this.Strength >= weapon.MinStrength)
            {
                _logger.DisplayMessage($"You equip the {weaponName}.");
                this.Weapon = weapon;
            }
            else
            {
                _logger.DisplayMessage($"You try to equip the weapon but you are either too dumb or weak. You keep your current weapon.");
            }
        }

        public int PlayerAttack()
        {
            int damage = 0;

           if (this.Weapon.PrimaryAttribute == "Intelligence")
            {
                damage = this.Weapon.Damage * this.Intelligence;
            }
            else if (this.Weapon.PrimaryAttribute == "Strength")
            {
                damage = this.Weapon.Damage * this.Strength;
            }
            else
            {
                _logger.DisplayMessage("Er zit een fout in PlayerAttack.");
            }

           _logger.DisplayMessage($"You deal {damage} damage.");

            return damage;
        }

        public virtual void TakeDamage(int damage)
        {
            this.Hitpoints -= damage;

            if (this.Hitpoints <= 0)
            {
                _logger.DisplayMessage("You're dead loser. And your life sucks. Go cry in a corner like the baby you are.");
            }
            else
            {
                _logger.DisplayMessage($"You have {this.Hitpoints} hitpoints left.");
            }
        }
    }
}
