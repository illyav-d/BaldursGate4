namespace BaldursGate4.Weapon
{
    public interface IWeapon
    {

        public string PrimaryAttribute { get; set; }
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }

        public string Name { get; set; }


    }
}
