﻿namespace BlizzardAPI.Wow.Character
{
    public class Pet
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string BattlePetGuid { get; set; }
        public string CreatureName { get; set; }

        public int SpellId { get; set; }
        public int CreatureId { get; set; }
        public int ItemId { get; set; }
        public int QualityId { get; set; }

        public bool IsFavorite { get; set; }
        public bool IsFirstAbilitySlotSelected { get; set; }
        public bool IsSecondAbilitySlotSelected { get; set; }
        public bool IsThirdAbilitySlotSelected { get; set; }
        public bool CanBattle { get; set; }

        public PetStats Stats;
    }
}
