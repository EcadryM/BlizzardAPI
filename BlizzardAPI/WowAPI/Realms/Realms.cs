using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WowAPI.Realms
{
    public class Realms
    {
        private List<Realm> realms = new List<Realm>();
        public List<Realm> RealmsList { get => realms; set => realms = value; }

        public Realms(string region, string locale)
        {
            var realmsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/realm/status?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (realmsData == null)
                return;

            for (var i = 0; i < (realmsData["realms"] as JArray).Count; i++)
            {
                RealmsList.Add(new Realm
                {
                    Type = realmsData["realms"][i]["type"],
                    Population = realmsData["realms"][i]["population"],
                    Name = realmsData["realms"][i]["name"],
                    Slug = realmsData["realms"][i]["slug"],
                    BattleGroup = realmsData["realms"][i]["battlegroup"],
                    Locale = realmsData["realms"][i]["locale"],
                    Timezone = realmsData["realms"][i]["timezone"],
                    Queue = realmsData["realms"][i]["queue"],
                    Status = realmsData["realms"][i]["status"],
                    ConnectedRealms = realmsData["realms"][i]["connected_realms"].ToObject<string[]>()
                });
            }
        }
    }
}
