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

        public DataResources.DataResources DataResources(string region, string locale)
        {
            return new DataResources.DataResources(region, locale);
        }

        public Boss.Boss Boss(string region, string locale)
        {
            return new Boss.Boss(region, locale);
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

        public Realms.Realms Realms(string region, string locale)
        {
            return new Realms.Realms(region, locale);
        }

        public Auction.DataStatus AuctionData(string realm, string region, string locale)
        {
            return new Auction.DataStatus(realm, region, locale);
        }

        public Guild.Guild Guild(string realm, string guildName, string region, string locale)
        {
            return new Guild.Guild(realm, guildName, region, locale);
        }

        public Pet.Pet Pet(string region, string locale)
        {
            return new Pet.Pet(region, locale);
        }

        public Spell.Spell Spell(string spellID, string region, string locale)
        {
            return new Spell.Spell(spellID, region, locale);

        }
        public Zone.Zone Zone(string region, string locale)
        {
            return new Zone.Zone(region, locale);
        }

        public Item.Item Item(string region, string locale)
        {
            return new Item.Item(region, locale);
        }
    }
}
