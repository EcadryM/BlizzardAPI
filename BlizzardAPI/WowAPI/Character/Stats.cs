namespace WowAPI.Character
{
    public class Stats
    {
        public string PowerType { get; set; }

        public int Health { get; set; }
        public int Power { get; set; }
        public int Str { get; set; }
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
            var statsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=stats&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (statsData == null)
                return;

            Health = statsData["stats"]["health"];
            Power = statsData["stats"]["power"];
            Str = statsData["stats"]["str"];
            Agi = statsData["stats"]["agi"];
            Int = statsData["stats"]["int"];
            Sta = statsData["stats"]["sta"];
            SpeedRating = statsData["stats"]["speedRating"];
            SpeedRatingBonus = statsData["stats"]["speedRatingBonus"];
            Crit = statsData["stats"]["crit"];
            CritRating = statsData["stats"]["critRating"];
            Haste = statsData["stats"]["haste"];
            HasteRating = statsData["stats"]["hasteRating"];
            HasteRatingPercent = statsData["stats"]["hasteRatingPercent"];
            Mastery = statsData["stats"]["mastery"];
            MasteryRating = statsData["stats"]["masteryRating"];
            Leech = statsData["stats"]["leech"];
            LeechRating = statsData["stats"]["leechRating"];
            LeechRatingBonus = statsData["stats"]["leechRatingBonus"];
            Versatility = statsData["stats"]["versatility"];
            VersatilityDamageDoneBonus = statsData["stats"]["versatilityDamageDoneBonus"];
            VersatilityHealingDoneBonus = statsData["stats"]["versatilityHealingDoneBonus"];
            VersatilityDamageTakenBonus = statsData["stats"]["versatilityDamageTakenBonus"];
            AvoidanceRating = statsData["stats"]["avoidanceRating"];
            AvoidanceRatingBonus = statsData["stats"]["avoidanceRatingBonus"];
            SpellPen = statsData["stats"]["spellPen"];
            SpellCrit = statsData["stats"]["spellCrit"];
            SpellCritRating = statsData["stats"]["spellCritRating"];
            Mana5 = statsData["stats"]["mana5"];
            Mana5Combat = statsData["stats"]["mana5Combat"];
            Armor = statsData["stats"]["armor"];
            Dodge = statsData["stats"]["dodge"];
            DodgeRating = statsData["stats"]["dodgeRating"];
            Parry = statsData["stats"]["parry"];
            ParryRating = statsData["stats"]["parryRating"];
            Block = statsData["stats"]["block"];
            BlockRating = statsData["stats"]["blockRating"];
            MainHandDmgMin = statsData["stats"]["mainHandDmgMin"];
            MainHandDmgMax = statsData["stats"]["mainHandDmgMax"];
            MainHandSpeed = statsData["stats"]["mainHandSpeed"];
            MainHandDps = statsData["stats"]["mainHandDps"];
            OffHandDmgMin = statsData["stats"]["offHandDmgMin"];
            OffHandDmgMax = statsData["stats"]["offHandDmgMax"];
            OffHandSpeed = statsData["stats"]["offHandSpeed"];
            OffHandDps = statsData["stats"]["offHandDps"];
            RangedDmgMin = statsData["stats"]["rangedDmgMin"];
            RangedDmgMax = statsData["stats"]["rangedDmgMax"];
            RangedSpeed = statsData["stats"]["rangedSpeed"];
            RangedDps = statsData["stats"]["rangedDps"];
        }
    }
}
