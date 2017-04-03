namespace WowAPI.Character
{
    public class Stats
    {
        public string PowerType { get; set; }

        public int Health { get; set; }
        public int Power { get; set; }
        public int Str { get; set }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Sta { get; set; }
        public int SpeedRating { get; set; }
        public int SpeedRatingBonus { get; set; }
        public int Crit { get; set; }
        public int CritRating { get; set; }
        public int Haste { get; set; }
        public int HasteRating { get; set; }
        public int HasteRatingPercent { get; set; }
        public int Mastery { get; set; }
        public int MasteryRating { get; set; }
        public int Leech { get; set; }
        public int LeechRating { get; set; }
        public int LeechRatingBonus { get; set; }
        public int Versatility { get; set; }
        public int VersatilityDamageDoneBonus { get; set; }
        public int VersatilityHealingDoneBonus { get; set; }
        public int VersatilityDamageTakenBonus { get; set; }
        public int AvoidanceRating { get; set; }
        public int AvoidanceRatingBonus { get; set; }
        public int SpellPen { get; set; }
        public int SpellCrit { get; set; }
        public int SpellCritRating { get; set; }
        public int Mana5 { get; set; }
        public int Mana5Combat { get; set; }
        public int Armor { get; set; }
        public int Dodge { get; set; }
        public int DodgeRating { get; set; }
        public int Parry { get; set; }
        public int ParryRating { get; set; }
        public int Block { get; set; }
        public int BlockRating { get; set; }
        public int MainHandDmgMin { get; set; }
        public int MainHandDmgMax { get; set; }
        public int MainHandSpeed { get; set; }
        public int MainHandDps { get; set; }
        public int OffHandDmgMin { get; set; }
        public int OffHandDmgMax { get; set; }
        public int OffHandSpeed { get; set; }
        public int OffHandDps { get; set; }
        public int RangedDmgMin { get; set; }
        public int RangedDmgMax { get; set; }
        public int RangedSpeed { get; set; }
        public int RangedDps { get; set; }

        public Stats(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
