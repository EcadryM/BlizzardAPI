using System;

namespace WowAPI.Guild
{
    public class Guild
    {
        private readonly string region, locale, realm, guildName;

        public Guild(string realm, string guildName, string region, string locale)
        {
            this.guildName = guildName;
            this.region = region;
            this.locale = locale;
            this.realm = realm;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { realm, guildName, region, locale });
        }

        public GuildInfo GuildInfo()
        {
            return CreateNewInstance(typeof(GuildInfo)) as GuildInfo;
        }

        public GuildMembers GuildMembers()
        {
            return CreateNewInstance(typeof(GuildMembers)) as GuildMembers;
        }

        public GuildAchievements GuildAchievements()
        {
            return CreateNewInstance(typeof(GuildAchievements)) as GuildAchievements;
        }

        public GuildNews GuildNews()
        {
            return CreateNewInstance(typeof(GuildNews)) as GuildNews;
        }

        public GuildChallenge GuildChallenge()
        {
            return CreateNewInstance(typeof(GuildChallenge)) as GuildChallenge;
        }
    }
}
