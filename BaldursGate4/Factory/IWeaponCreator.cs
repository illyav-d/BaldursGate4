using GitGate4.Weapon;

namespace GitGate4.Factory
{
    public interface IWeaponCreator
    {
        IWeapon Create(Weapons weapon);
    }
}