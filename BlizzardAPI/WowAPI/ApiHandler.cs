namespace WowAPI
{
    public class ApiHandler
    {
        public static string ApiKey { get; set; }

        public ApiHandler(string apiKey)
        {
            ApiKey = apiKey;
        }

        public Character.Character Character(string name, string realm, string region, string locale)
        {
            return new Character.Character(name, realm, region, locale);
        }

        public Mounts.Mounts Mounts(string region, string locale)
        {
            return new Mounts.Mounts(region, locale);
        }

        public PvP.Leaderboards Leaderboards(string bracketSlug, string region, string locale)
        {
            return new PvP.Leaderboards(bracketSlug, region, locale);
        }

        public Quest.Quest Quest(string questId, string region, string locale)
        {
            return new Quest.Quest(questId, region, locale);
        }

        public Recipes.Recipe Recipe(string recipeId, string region, string locale)
        {
            return new Recipes.Recipe(recipeId, region, locale);
        }

        public DataResources.Battlegroups Battlegroups(string region, string locale)
        {
            return new DataResources.Battlegroups(region, locale);
        }

        public DataResources.CharacterRaces Races(string region, string locale)
        {
            return new DataResources.CharacterRaces(region, locale);
        }

        public DataResources.CharacterClasses Classes(string region, string locale)
        {
            return new DataResources.CharacterClasses(region, locale);
        }

        public DataResources.GuildPerks GuildPerks(string region, string locale)
        {
            return new DataResources.GuildPerks(region, locale);
        }

        public DataResources.PetsTypes PetsTypes(string region, string locale)
        {
            return new DataResources.PetsTypes(region, locale);
        }

        public Realms.Realms Realms(string region, string locale)
        {
            return new Realms.Realms(region, locale);
        }

        public Auction.DataStatus AuctionData(string realm, string region, string locale)
        {
            return new Auction.DataStatus(realm, region, locale);
        }

        public Boss.BossList BossList(string region, string locale)
        {
            return new Boss.BossList(region, locale);
        }

        public Boss.BossInfo BossInfo(string bossId, string region, string locale)
        {
            return new Boss.BossInfo(bossId, region, locale);
        }

        public Guild.GuildInfo GuildInfo(string realm, string guildName, string region, string locale)
        {
            return new Guild.GuildInfo(realm, guildName, region, locale);
        }

        public Guild.GuildMembers GuildMembers(string realm, string guildName, string region, string locale)
        {
            return new Guild.GuildMembers(realm, guildName, region, locale);
        }

        public Guild.GuildAchievements GuildAchievements(string realm, string guildName, string region, string locale)
        {
            return new Guild.GuildAchievements(realm, guildName, region, locale);
        }

        public Guild.GuildNews GuildNews(string realm, string guildName, string region, string locale)
        {
            return new Guild.GuildNews(realm, guildName, region, locale);
        }

        public Guild.GuildChallenge GuildChallenge(string realm, string guildName, string region, string locale)
        {
            return new Guild.GuildChallenge(realm, guildName, region, locale);
        }

        public Pet.PetsList PetsList(string region, string locale)
        {
            return new Pet.PetsList(region, locale);
        }

        public Pet.PetAbility PetAbility(string abilityID, string region, string locale)
        {
            return new Pet.PetAbility(abilityID, region, locale);
        }
    }
}
