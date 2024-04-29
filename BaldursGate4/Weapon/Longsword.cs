namespace BaldursGate4.Weapon
{
    public class Longsword : IWeapon
    {
        public Longsword()
        {
            PrimaryAttribute = "Strength";
            MinStrength = 6;
            MinIntelligence = 3;
            Damage = 4;
        }
        public string PrimaryAttribute { get; set; }
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
    }
}

