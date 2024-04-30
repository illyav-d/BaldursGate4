namespace BaldursGate4.Weapon
{
    internal class BattleAxe : IWeapon
    {
        public BattleAxe()
        {
            PrimaryAttribute = "Strength";
            MinStrength = 9;
            MinIntelligence = 1;
            Damage = 4;
            Name = "Battleaxe";
        }
        public string PrimaryAttribute { get; set; }
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

    }
}
