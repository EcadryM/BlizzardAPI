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
    }
}
