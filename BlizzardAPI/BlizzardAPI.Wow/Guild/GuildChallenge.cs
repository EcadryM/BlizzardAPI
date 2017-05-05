using System.Collections.Generic;

namespace BlizzardAPI.Wow.Guild
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
            Emblem = guildChallengeData["emblem"].ToObject<Emblem>();
            Challenges = guildChallengeData["challenge"].ToObject<List<Challenge>>();
        }
    }
}
