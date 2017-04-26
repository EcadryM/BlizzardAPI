using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Guild
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
            Emblem = new Emblem
            {
                Icon = guildMembersData["emblem"]["icon"],
                IconColor = guildMembersData["emblem"]["iconColor"],
                IconColorId = guildMembersData["emblem"]["iconColorId"],
                Border = guildMembersData["emblem"]["border"],
                BorderColor = guildMembersData["emblem"]["borderColor"],
                BorderColorId = guildMembersData["emblem"]["borderColorId"],
                BackgroundColor = guildMembersData["emblem"]["backgroundColor"],
                BackgroundColorId = guildMembersData["emblem"]["backgroundColorId"]
            };

            for (var i = 0; i < (guildMembersData["members"] as JArray).Count; i++)
            {
                Members.Add(new Member
                {
                    Character = new Character
                    {
                        Name = guildMembersData["members"][i]["character"]["name"],
                        Realm = guildMembersData["members"][i]["character"]["realm"],
                        Battlegroup = guildMembersData["members"][i]["character"]["battlegroup"],
                        Class = guildMembersData["members"][i]["character"]["class"],
                        Race = guildMembersData["members"][i]["character"]["race"],
                        Gender = guildMembersData["members"][i]["character"]["gender"],
                        Level = guildMembersData["members"][i]["character"]["level"],
                        AchievementPoints = guildMembersData["members"][i]["character"]["achievementPoints"],
                        Thumbnail = guildMembersData["members"][i]["character"]["thumbnail"],
                        Guild = guildMembersData["members"][i]["character"]["guild"],
                        GuildRealm = guildMembersData["members"][i]["character"]["guildRealm"],
                        LastModified = guildMembersData["members"][i]["character"]["lastModified"]
                    },
                    Rank = guildMembersData["members"][i]["rank"]
                });

                if (guildMembersData["members"][i]["character"]["spec"] != null)
                {
                    Members[i].Character.Spec = new Spec
                    {
                        Name = guildMembersData["members"][i]["character"]["spec"]["name"],
                        Role = guildMembersData["members"][i]["character"]["spec"]["role"],
                        BackgroundImage = guildMembersData["members"][i]["character"]["spec"]["BackgroundImage"],
                        Icon = guildMembersData["members"][i]["character"]["spec"]["icon"],
                        Description = guildMembersData["members"][i]["character"]["spec"]["description"],
                        Order = guildMembersData["members"][i]["character"]["spec"]["order"]
                    };
                }
            }
        }
    }
}
