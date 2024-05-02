using GitGate4.Weapon;

namespace GitGate4.Factory
{
    public class WeaponCreator : IWeaponCreator
    {
        public IWeapon Create(Weapons weapon)
        {
            switch (weapon)
            {
                case Weapons.Longsword:
                    return new Longsword();

                case Weapons.Battleaxe:
                    return new BattleAxe();

                case Weapons.Staff:
                    return new Staff();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
