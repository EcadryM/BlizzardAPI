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
    }
}
