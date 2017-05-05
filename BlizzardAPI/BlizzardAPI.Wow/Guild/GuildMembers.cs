using System.Collections.Generic;

namespace BlizzardAPI.Wow.Guild
{
    public class GuildMembers : GuildInfo
    {
        private List<Member> members = new List<Member>();
        public List<Member> Members { get => members; set => members = value; }
        public GuildMembers(string realm, string guildName, string region, string locale) : base(realm, guildName, region, locale)
        {
            var guildMembersData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/wow/guild/{realm}/{guildName}?fields=members&locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (guildMembersData == null)
                return;

            LastModified = guildMembersData["lastModified"];
            Name = guildMembersData["name"];
            Realm = guildMembersData["realm"];
            Battlegroup = guildMembersData["battlegroup"];
            Level = guildMembersData["level"];
            Side = guildMembersData["side"];
            AchievementPoints = guildMembersData["achievementPoints"];
            Emblem = guildMembersData["emblem"].ToObject<Emblem>();
            Members = guildMembersData["members"].ToObject<List<Member>>();
        }
    }
}
