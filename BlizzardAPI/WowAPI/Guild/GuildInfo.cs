namespace WowAPI.Guild
{
    public class GuildInfo
    {
        public long LastModified { get; set; }
        public string Name { get; set; }
        public string Realm { get; set; }
        public string Battlegroup { get; set; }
        public int Level { get; set; }
        public int Side { get; set; }
        public int AchievementPoints { get; set; }
        public Emblem Emblem { get; set; }

        public GuildInfo(string realm, string guildName, string region, string locale)
        {
            var guildData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/guild/{realm}/{guildName}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (guildData == null)
                return;

            LastModified = guildData["lastModified"];
            Name = guildData["name"];
            Realm = guildData["realm"];
            Battlegroup = guildData["battlegroup"];
            Level = guildData["level"];
            Side = guildData["side"];
            AchievementPoints = guildData["achievementPoints"];
            Emblem = new Emblem
            {
                Icon = guildData["emblem"]["icon"],
                IconColor = guildData["emblem"]["iconColor"],
                IconColorId = guildData["emblem"]["iconColorId"],
                Border = guildData["emblem"]["border"],
                BorderColor = guildData["emblem"]["borderColor"],
                BorderColorId = guildData["emblem"]["borderColorId"],
                BackgroundColor = guildData["emblem"]["backgroundColor"],
                BackgroundColorId = guildData["emblem"]["backgroundColorId"]
            };
        }
    }
}
