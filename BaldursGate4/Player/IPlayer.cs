using GitGate4.Weapon;

namespace GitGate4.Player
{
    public interface IPlayer : IPlayerStats
    {
        IWeapon Weapon { get; set; }
        void DisplayStats();
        void PickupWeapon(IWeapon weapon);
        int PlayerAttack();
        void TakeDamage(int damage);

    }
}
