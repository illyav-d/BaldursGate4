using GitGate4.Logger;
using GitGate4.Weapon;

namespace GitGate4.Player
{
    public interface IPlayer : IPlayerStats
    {
        IWeapon Weapon { get; set; }
        void DisplayStats(IConsoleLogger logger);
        void PickupWeapon(IWeapon weapon, IConsoleLogger logger);
        int PlayerAttack();
        void TakeDamage(int damage);

    }
}
