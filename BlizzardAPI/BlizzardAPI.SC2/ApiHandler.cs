namespace BlizzardAPI.SC2
{
    public class ApiHandler
    {
        public static string ApiKey { get; set; }

        public ApiHandler(string apiKey)
        {
            ApiKey = apiKey;
        }

        public Profile.Profile Profile(string accountId, string name, string region, string profileRegion, string locale)
        {
            return new Profile.Profile(accountId, name, region, profileRegion, locale);
        }

        public Ladder.Ladder Ladder(string ladderId, string region, string locale)
        {
            return new Ladder.Ladder(ladderId, region, locale);
        }

        public DataResources.DataResources DataResources(string region, string locale)
        {
            return new DataResources.DataResources(region, locale);
        }
    }
}
