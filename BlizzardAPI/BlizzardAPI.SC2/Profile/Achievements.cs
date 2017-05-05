using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlizzardAPI.SC2.Profile
{
    public class Achievements
    {
        public Points Points { get; set; }
        [JsonProperty("achievements")]
        public List<Achievement> AchievementsList { get; set; }
    }
}
