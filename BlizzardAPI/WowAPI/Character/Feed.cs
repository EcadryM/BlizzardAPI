using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Feed
    {
        public long LastModified { get; set; }
        public string Name { get; set; }
        public string Realm { get; set; }
        public string Battlegroup { get; set; }
        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public string Thumbnail { get; set; }
        public string CalcClass { get; set; }
        public int Faction { get; set; }
        public List<FeedProperties> FeedList { get; set; }
        public int TotalHonorableKills { get; set; }

        public Feed(string name, string realm, string region, string locale)
        {
            var feedData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=feed&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (feedData == null)
                return;

            LastModified = feedData["lastModified"];
            Name = feedData["name"];
            Realm = feedData["realm"];
            Battlegroup = feedData["battlegroup"];
            Class = feedData["class"];
            Race = feedData["race"];
            Gender = feedData["gender"];
            Level = feedData["level"];
            AchievementPoints = feedData["achievementPoints"];
            Thumbnail = feedData["thumbnail"];
            CalcClass = feedData["calcClass"];
            Faction = feedData["faction"];
            FeedList = feedData["feed"].ToObject<List<FeedProperties>>();
            TotalHonorableKills = feedData["totalHonorableKills"];
        }
    }
}
