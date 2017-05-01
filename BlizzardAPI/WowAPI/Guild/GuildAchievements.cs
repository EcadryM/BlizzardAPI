namespace WowAPI.Guild
{
    public class GuildAchievements : GuildInfo
    {
        public long[] AchievementsCompleted { get; set; }
        public long[] AchievementsCompletedTimestamp { get; set; }
        public long[] Criteria { get; set; }
        public long[] CriteriaQuantity { get; set; }
        public long[] CriteriaTimestamp { get; set; }
        public long[] CriteriaCreated { get; set; }

        public GuildAchievements(string realm, string guildName, string region, string locale) : base(realm, guildName, region, locale)
        {
            var guildAchievementsData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/wow/guild/{realm}/{guildName}?fields=achievements&locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (guildAchievementsData == null)
                return;

            LastModified = guildAchievementsData["lastModified"];
            Name = guildAchievementsData["name"];
            Realm = guildAchievementsData["realm"];
            Battlegroup = guildAchievementsData["battlegroup"];
            Level = guildAchievementsData["level"];
            Side = guildAchievementsData["side"];
            AchievementPoints = guildAchievementsData["achievementPoints"];
            Emblem = guildAchievementsData["emblem"].ToObject<Emblem>();
            AchievementsCompleted = guildAchievementsData["achievements"]["achievementsCompleted"].ToObject<long[]>();
            AchievementsCompletedTimestamp = guildAchievementsData["achievements"]["achievementsCompletedTimestamp"].ToObject<long[]>();
            Criteria = guildAchievementsData["achievements"]["criteria"].ToObject<long[]>();
            CriteriaQuantity = guildAchievementsData["achievements"]["criteriaQuantity"].ToObject<long[]>();
            CriteriaTimestamp = guildAchievementsData["achievements"]["criteriaTimestamp"].ToObject<long[]>();
            CriteriaCreated = guildAchievementsData["achievements"]["criteriaCreated"].ToObject<long[]>();
        }
    }
}
