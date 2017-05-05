using System.Collections.Generic;

namespace BlizzardAPI.Wow.Guild
{
    public class GuildNews : GuildInfo
    {
        private List<News> news = new List<News>();
        public List<News> News { get => news; set => news = value; }

        public GuildNews(string realm, string guildName, string region, string locale) : base(realm, guildName, region, locale)
        {
            var guildNewsData = ApiHelper.GetJsonFromUrl(
             $"https://{region}.api.battle.net/wow/guild/{realm}/{guildName}?fields=news&locale={locale}&apikey={ApiHandler.ApiKey}"
         );

            if (guildNewsData == null)
                return;

            LastModified = guildNewsData["lastModified"];
            Name = guildNewsData["name"];
            Realm = guildNewsData["realm"];
            Battlegroup = guildNewsData["battlegroup"];
            Level = guildNewsData["level"];
            Side = guildNewsData["side"];
            AchievementPoints = guildNewsData["achievementPoints"];
            Emblem = guildNewsData["emblem"].ToObject<Emblem>();
            News = guildNewsData["news"].ToObject<List<News>>();
        }
    }
}
