namespace Blizzard.SC2
{
    public class ApiHandler
    {
        public static string ApiKey { get; set; }

        public ApiHandler(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
