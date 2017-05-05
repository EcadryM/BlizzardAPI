using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.DataResources
{
    public class Battlegroups
    {
        private List<Battlegroup> battlegroups = new List<Battlegroup>();
        public List<Battlegroup> BattlegroupsList { get => battlegroups; set => battlegroups = value; }
        public Battlegroups(string region, string locale)
        {
            var battlegroupsData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/wow/data/battlegroups/?locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (battlegroupsData == null)
                return;

            for (var i = 0; i < (battlegroupsData["battlegroups"] as JArray).Count; i++)
            {
                BattlegroupsList.Add(new Battlegroup
                {
                    Name = battlegroupsData["battlegroups"][i]["name"],
                    Slug = battlegroupsData["battlegroups"][i]["slug"]
                });
            }
        }
    }
}
