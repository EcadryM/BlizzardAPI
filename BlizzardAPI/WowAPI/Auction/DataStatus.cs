namespace WowAPI.Auction
{
    public class DataStatus
    {
        public string Url { get; set; }
        public long LastModified { get; set; }

        public DataStatus(string realm, string region, string locale)
        {
            var statusData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/auction/data/{realm}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (statusData == null)
                return;

            Url = statusData["files"][0]["url"];
            LastModified = statusData["files"][0]["lastModified"];
        }
    }
}
