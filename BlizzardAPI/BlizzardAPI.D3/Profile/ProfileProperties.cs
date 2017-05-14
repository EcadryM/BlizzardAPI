using System.Collections.Generic;

namespace BlizzardAPI.D3.Profile
{
    public class ProfileProperties
    {
        public string BattleTag { get; set; }
        public int ParagonLevel { get; set; }
        public int ParagonLevelHardcore { get; set; }
        public int ParagonLevelSeason { get; set; }
        public int ParagonLevelSeasonHardcore { get; set; }
        public string GuildName { get; set; }
        public List<Hero> Heroes { get; set; }
        public int LastHeroPlayed { get; set; }
        public int LastUpdated { get; set; }
        public Kills Kills { get; set; }
        public int HighestHardcoreLevel { get; set; }
        public TimePlayed TimePlayed { get; set; }
        public Progression Progression { get; set; }
        public List<object> FallenHeroes { get; set; }
        public Blacksmith Blacksmith { get; set; }
        public Specialization Jeweler { get; set; }
        public Specialization Mystic { get; set; }
        public Specialization BlacksmithHardcore { get; set; }
        public Specialization JewelerHardcore { get; set; }
        public Specialization MysticHardcore { get; set; }
        public Specialization BlacksmithSeason { get; set; }
        public Specialization JewelerSeason { get; set; }
        public Specialization MysticSeason { get; set; }
        public Specialization BlacksmithSeasonHardcore { get; set; }
        public Specialization JewelerSeasonHardcore { get; set; }
        public Specialization MysticSeasonHardcore { get; set; }
    }
}
