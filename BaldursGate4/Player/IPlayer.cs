using BaldursGate4.Weapon;

namespace BaldursGate4.Player
{
    internal interface IPlayer : IPlayerStats
    {
        IWeapon Weapon { get; set; }
        public void DisplayStats();
        public void PickupWeapon(IWeapon weapon, Weapons weaponName);

    }
}
