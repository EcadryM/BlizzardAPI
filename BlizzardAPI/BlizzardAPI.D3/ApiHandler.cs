namespace BlizzardAPI.D3
{
    public class ApiHandler
    {
        public static string ApiKey { get; set; }

        public ApiHandler(string apiKey)
        {
            ApiKey = apiKey;
        }

        public Profile.Profile Profile(string battleTag, string region, string locale)
        {
            return new Profile.Profile(battleTag, region, locale);
        }
    }
}
