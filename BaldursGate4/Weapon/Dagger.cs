namespace BaldursGate4.Weapon
{
    internal class Dagger : IWeapon
    {
        public Dagger()
        {
            PrimaryAttribute = "Strength";
            MinStrength = 1;
            MinIntelligence = 1;
            Damage = 2;
            Name = "Dagger";
        }
        public string PrimaryAttribute { get; set; }
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

    }
}
