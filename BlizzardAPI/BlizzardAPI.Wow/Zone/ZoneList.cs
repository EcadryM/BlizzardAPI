using System.Collections.Generic;

namespace BlizzardAPI.Wow.Zone
{
    public class ZoneList
    {
        public List<ZoneInfo> Zones { get; set; }

        public ZoneList(string region, string locale)
        {
            var zonesData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/zone/?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (zonesData == null)
                return;

            Zones = zonesData["zones"].ToObject<List<ZoneInfo>>();
        }
    }
}
