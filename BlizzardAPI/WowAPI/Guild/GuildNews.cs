using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Guild
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
            Emblem = new Emblem
            {
                Icon = guildNewsData["emblem"]["icon"],
                IconColor = guildNewsData["emblem"]["iconColor"],
                IconColorId = guildNewsData["emblem"]["iconColorId"],
                Border = guildNewsData["emblem"]["border"],
                BorderColor = guildNewsData["emblem"]["borderColor"],
                BorderColorId = guildNewsData["emblem"]["borderColorId"],
                BackgroundColor = guildNewsData["emblem"]["backgroundColor"],
                BackgroundColorId = guildNewsData["emblem"]["backgroundColorId"]
            };

            for (var i = 0; i < (guildNewsData["news"] as JArray).Count; i++)
            {
                var achievement = new Achievement();

                if (guildNewsData["news"][i]["achievement"] != null)
                {
                    achievement.Id = guildNewsData["news"][i]["achievement"]["id"];
                    achievement.Title = guildNewsData["news"][i]["achievement"]["title"];
                    achievement.Points = guildNewsData["news"][i]["achievement"]["points"];
                    achievement.Description = guildNewsData["news"][i]["achievement"]["description"];

                    if (guildNewsData["news"][i]["achievement"]["rewandItems"] != null)
                    {
                        achievement.RewardItems = guildNewsData["news"][i]["achievement"]["rewandItems"].ToObject<long[]>();
                    }

                    achievement.Icon = guildNewsData["news"][i]["achievement"]["icon"];

                    if (guildNewsData["news"][i]["achievement"]["criteria"] != null)
                    {
                        for (var j = 0; j < (guildNewsData["news"][i]["achievement"]["criteria"] as JArray).Count; j++)
                        {
                            achievement.Criteria.Add(new Criterion
                            {
                                Id = guildNewsData["news"][i]["achievement"]["criteria"][j]["id"],
                                Description = guildNewsData["news"][i]["achievement"]["criteria"][j]["description"],
                                OrderIndex = guildNewsData["news"][i]["achievement"]["criteria"][j]["orderIndex"],
                                Max = guildNewsData["news"][i]["achievement"]["criteria"][j]["max"],
                            });
                        }
                    }
                    
                    achievement.AccountWide = guildNewsData["news"][i]["achievement"]["accountWide"];
                    achievement.FactionId = guildNewsData["news"][i]["achievement"]["fanctionId"];
                }

                News.Add(new News
                {
                    Type = guildNewsData["news"][i]["type"],
                    Character = guildNewsData["news"][i]["character"],
                    Timestamp = guildNewsData["news"][i]["timestamp"],
                    Context = guildNewsData["news"][i]["context"],
                    BonusLists = guildNewsData["news"][i]["bonusLists"].ToObject<long[]>(),
                    Achievement = achievement
                });
            }
        }
    }
}
