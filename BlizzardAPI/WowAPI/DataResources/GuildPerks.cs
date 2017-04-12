using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.DataResources
{
    public class GuildPerks
    {
        private List<GuildPerk> perks = new List<GuildPerk>();
        public List<GuildPerk> Perks { get => perks; set => perks = value; }
        
        public GuildPerks(string region, string locale)
        {
            var perksData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/data/guild/perks?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (perksData == null)
                return;

            for (var i = 0; i < (perksData["perks"] as JArray).Count; i++)
            {
                Perks.Add(new GuildPerk
                {
                    GuildLevel = perksData["perks"][i]["guildLevel"],
                    GuildSpell = new GuildSpell
                    {
                        Id = perksData["perks"][i]["spell"]["id"],
                        Name = perksData["perks"][i]["spell"]["name"],
                        Subtext = perksData["perks"][i]["spell"]["subtext"],
                        Icon = perksData["perks"][i]["spell"]["icon"],
                        Description = perksData["perks"][i]["spell"]["description"],
                        CastTime = perksData["perks"][i]["spell"]["castTime"]
                    }
                });
            }
        }
    }
}
