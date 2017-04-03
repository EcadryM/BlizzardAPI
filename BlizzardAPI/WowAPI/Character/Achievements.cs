using System;

namespace WowAPI.Character
{
    class Achievements
    {
        public int[] AchievementsCompleted { get; set; }
        public int[] Criteria { get; set; }

        public long[] AchievementsCompletedTimestamp { get; set; }
        public long[] CriteriaQuantity { get; set; }
        public long[] CriteriaTimestamp { get; set; }
        public long[] CriteriaCreated { get; set; }

        public Achievements(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
