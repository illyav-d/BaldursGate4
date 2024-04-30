namespace BaldursGate4.Weapon
{
    public class Staff : IWeapon
    {
        public Staff()
        {
            PrimaryAttribute = "Intelligence";
            MinStrength = 2;
            MinIntelligence = 8;
            Damage = 3;
        }
        public string PrimaryAttribute { get; set; }
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
    }


}
