using System.Collections.Generic;

namespace WowAPI.Zone
{
    public class ZoneList
    {
        private List<Zone> zones = new List<Zone>();
        public List<Zone> Zones { get => zones; set => zones = value; }

        public ZoneList(string region, string locale)
        {
            var zonesData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/zone/?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (zonesData == null)
                return;

            Zones = zonesData["zones"].ToObject<List<Zone>>();
        }
    }
}
