namespace BlizzardAPI.SC2.Profile
{
    public class ProfileInfo
    {
        public int Id { get; set; }
        public int Realm { get; set; }
        public string DisplayName { get; set; }
        public string ClanName { get; set; }
        public string ClanTag { get; set; }
        public string ProfilePath { get; set; }
        public Portrait Portrait { get; set; }
        public Career Career { get; set; }
        public SwarmLevels SwarmLevels { get; set; }
        public Campaign Campaign { get; set; }
        public Season Season { get; set; }
        public Rewards Rewards { get; set; }
        public Achievements Achievements { get; set; }

        public ProfileInfo(string accountId, string name, string region, string profileRegion, string locale)
        {
            var profileData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/sc2/profile/{accountId}/{profileRegion}/{name}/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (profileData == null)
                return;

            Id = profileData["id"];
            Realm = profileData["realm"];
            DisplayName = profileData["displayName"];
            ClanName = profileData["clanName"];
            ClanTag = profileData["clanTag"];
            ProfilePath = profileData["profilePath"];
            Portrait = profileData["portrait"].ToObject<Portrait>();
            Career = profileData["career"].ToObject<Career>();
            SwarmLevels = profileData["swarmLevels"].ToObject<SwarmLevels>();
            Campaign = profileData["campaign"].ToObject<Campaign>();
            Season = profileData["season"].ToObject<Season>();
            Rewards = profileData["rewards"].ToObject<Rewards>();
            Achievements = profileData["achievements"].ToObject<Achievements>();
        }
    }
}
