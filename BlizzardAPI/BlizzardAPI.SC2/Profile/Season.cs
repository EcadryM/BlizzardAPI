using System.Collections.Generic;

namespace BlizzardAPI.SC2.Profile
{
    public class Season
    {
        public int SeasonId { get; set; }
        public int SeasonNumber { get; set; }
        public int SeasonYear { get; set; }
        public int TotalGamesThisSeason { get; set; }
        public List<Stat> Stats { get; set; }
    }
}
