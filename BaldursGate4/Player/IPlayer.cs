using BaldursGate4.Weapon;

namespace BaldursGate4.Player
{
    public interface IPlayer : IPlayerStats
    {
        IWeapon Weapon { get; set; }
        void DisplayStats();
        void PickupWeapon(IWeapon weapon, Weapons weaponName);
        int PlayerAttack();
        void TakeDamage(int damage);

    }
}
