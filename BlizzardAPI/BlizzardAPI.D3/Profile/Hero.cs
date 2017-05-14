using Newtonsoft.Json;

namespace BlizzardAPI.D3.Profile
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public Kills Kills { get; set; }
        public int ParagonLevel { get; set; }
        public bool Hardcore { get; set; }
        public bool Seasonal { get; set; }
        public bool Dead { get; set; }
        [JsonProperty("last-updated")]
        public int LastUpdated { get; set; }
}
}
