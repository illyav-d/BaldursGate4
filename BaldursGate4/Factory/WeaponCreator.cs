using BaldursGate4.Weapon;

namespace BaldursGate4.Factory
{
    public class WeaponCreator
    {
        public IWeapon createAWeapon(Weapons weapon)
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
