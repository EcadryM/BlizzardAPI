namespace WowAPI.Character
{
    public class Achievements
    {
        public int[] AchievementsCompleted { get; set; }
        public int[] Criteria { get; set; }

        public long[] AchievementsCompletedTimestamp { get; set; }
        public long[] CriteriaQuantity { get; set; }
        public long[] CriteriaTimestamp { get; set; }
        public long[] CriteriaCreated { get; set; }

        public Achievements(string name, string realm, string region, string locale)
        {
            var achievementsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=achievements&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (achievementsData == null)
                return;

            AchievementsCompleted = achievementsData.achievements["achievementsCompleted"].ToObject<int[]>();
            Criteria = achievementsData.achievements["criteria"].ToObject<int[]>();
            AchievementsCompletedTimestamp = achievementsData.achievements["achievementsCompletedTimestamp"].ToObject<long[]>();
            CriteriaQuantity = achievementsData.achievements["criteriaQuantity"].ToObject<long[]>();
            CriteriaTimestamp = achievementsData.achievements["criteriaTimestamp"].ToObject<long[]>();
            CriteriaCreated = achievementsData.achievements["criteriaCreated"].ToObject<long[]>();
        }
    }
}
