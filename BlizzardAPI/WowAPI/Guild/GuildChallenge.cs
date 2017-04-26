using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Guild
{
    public class GuildChallenge : GuildInfo
    {
        private List<Challenge> challenges = new List<Challenge>();
        public List<Challenge> Challenges { get => challenges; set => challenges = value; }
        public GuildChallenge(string realm, string guildName, string region, string locale) : base(realm, guildName, region, locale)
        {
            var guildChallengeData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/wow/guild/{realm}/{guildName}?fields=challenge&locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (guildChallengeData == null)
                return;

            LastModified = guildChallengeData["lastModified"];
            Name = guildChallengeData["name"];
            Realm = guildChallengeData["realm"];
            Battlegroup = guildChallengeData["battlegroup"];
            Level = guildChallengeData["level"];
            Side = guildChallengeData["side"];
            AchievementPoints = guildChallengeData["achievementPoints"];
            Emblem = new Emblem
            {
                Icon = guildChallengeData["emblem"]["icon"],
                IconColor = guildChallengeData["emblem"]["iconColor"],
                IconColorId = guildChallengeData["emblem"]["iconColorId"],
                Border = guildChallengeData["emblem"]["border"],
                BorderColor = guildChallengeData["emblem"]["borderColor"],
                BorderColorId = guildChallengeData["emblem"]["borderColorId"],
                BackgroundColor = guildChallengeData["emblem"]["backgroundColor"],
                BackgroundColorId = guildChallengeData["emblem"]["backgroundColorId"]
            };

            for (var i = 0; i < (guildChallengeData["challenge"] as JArray).Count; i++)
            {
                List<Group> groups = new List<Group>();
                for (int j = 0; j < (guildChallengeData["challenge"][i]["groups"] as JArray).Count; j++)
                {
                    groups.Add(new Group
                    {
                        Ranking = guildChallengeData["challenge"][i]["groups"][j]["ranking"],
                        Time = guildChallengeData["challenge"][i]["groups"][j]["time"].ToObject<GroupTime>(),
                        Date = guildChallengeData["challenge"][i]["groups"][j]["date"],
                        Fanction = guildChallengeData["challenge"][i]["groups"][j]["fanction"],
                        IsRecurring = guildChallengeData["challenge"][i]["groups"][j]["isRecurring"],
                        Members = guildChallengeData["challenge"][i]["groups"][j]["members"].ToObject<List<ChallegeMember>>()
                    });
                }
                Challenges.Add(new Challenge
                {
                    Realm = new Realm
                    {
                        Name = guildChallengeData["challenge"][i]["realm"]["name"],
                        Slug = guildChallengeData["challenge"][i]["realm"]["slug"],
                        Battlegroup = guildChallengeData["challenge"][i]["realm"]["battlegroup"],
                        Locale = guildChallengeData["challenge"][i]["realm"]["locale"],
                        Timezone = guildChallengeData["challenge"][i]["realm"]["timezone"],
                        ConnectedRealms = guildChallengeData["challenge"][i]["realm"]["connected_realms"].ToObject<List<string>>()
                    },
                    Map = new Map
                    {
                        Id = guildChallengeData["challenge"][i]["map"]["id"],
                        Name = guildChallengeData["challenge"][i]["map"]["name"],
                        Slug = guildChallengeData["challenge"][i]["map"]["slug"],
                        HasChallengeMode = guildChallengeData["challenge"][i]["map"]["hasChallengeMode"],
                        BronzeCriteria = guildChallengeData["challenge"][i]["map"]["bronzeCriteria"].ToObject<BronzeCriteria>(),
                        SilverCriteria = guildChallengeData["challenge"][i]["map"]["bronzeCriteria"].ToObject<SilverCriteria>(),
                        GoldCriteria = guildChallengeData["challenge"][i]["map"]["bronzeCriteria"].ToObject<GoldCriteria>()
                    },
                    Groups = groups
                });
            }
        }
    }
}
