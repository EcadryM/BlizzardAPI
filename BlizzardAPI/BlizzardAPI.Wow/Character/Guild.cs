namespace BlizzardAPI.Wow.Character
{
    public class Guild
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public string Members { get; set; }
        public string AchievementPoints { get; set; }

        public Emblem Emblem { get; set; }

        public Guild(string name, string realm, string region, string locale)
        {
            var guildData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=guild&locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (guildData == null)
                return;

            if (guildData.guild != null)
            {
                Name = guildData.guild["name"];
                Realm = guildData.guild["realm"];
                BattleGroup = guildData.guild["battlegroup"];
                Members = guildData.guild["members"];
                AchievementPoints = guildData.guild["achievementPoints"];

                Emblem = new Emblem
                {
                    Icon = guildData.guild.emblem["icon"],
                    IconColorId = guildData.guild.emblem["iconColorId"],
                    Border = guildData.guild.emblem["border"],
                    BorderColorId = guildData.guild.emblem["borderColorId"],
                    BackgroundColorId = guildData.guild.emblem["backgroundColorId"],

                    IconColor = guildData.guild.emblem["iconColor"],
                    BorderColor = guildData.guild.emblem["borderColor"],
                    BackgroundColor = guildData.guild.emblem["backgroundColor"]
                };
            }
        }
    }
}
