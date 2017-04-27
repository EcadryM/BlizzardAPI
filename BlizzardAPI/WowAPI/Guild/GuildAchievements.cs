namespace WowAPI.Guild
{
    public class GuildAchievements : GuildInfo
    {
        public int[] AchievementsCompleted { get; set; }
        public long[] AchievementsCompletedTimestamp { get; set; }
        public int[] Criteria { get; set; }
        public int[] CriteriaQuantity { get; set; }
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
            AchievementsCompleted = guildAchievementsData["achievements"]["achievementsCompleted"].ToObject<int[]>();
            AchievementsCompletedTimestamp = guildAchievementsData["achievements"]["achievementsCompletedTimestamp"].ToObject<long[]>();
            Criteria = guildAchievementsData["achievements"]["criteria"].ToObject<int[]>();
            CriteriaQuantity = guildAchievementsData["achievements"]["criteriaQuantity"].ToObject<int[]>();
            CriteriaTimestamp = guildAchievementsData["achievements"]["criteriaTimestamp"].ToObject<long[]>();
            CriteriaCreated = guildAchievementsData["achievements"]["criteriaCreated"].ToObject<long[]>();
        }
    }
}
