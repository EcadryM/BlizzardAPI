using System.Collections.Generic;

namespace BlizzardAPI.SC2.Profile
{
    public class CurrentSeason
    {
        public List<Ladder> Ladder { get; set; }
        public List<Character> Characters { get; set; }
        public List<object> NonRanked { get; set; }
    }
}
