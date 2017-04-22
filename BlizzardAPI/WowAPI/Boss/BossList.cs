using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Boss
{
    public class BossList
    {
        private List<Boss> bosses = new List<Boss>();
        public List<Boss> Bosses { get => bosses; set => bosses = value; }

        public BossList(string region, string locale)
        {
            var bossListData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/boss/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (bossListData == null)
                return;

            for (var i = 0; i < (bossListData["bosses"] as JArray).Count; i++)
            {
                var npcs = new List<Npc>();
                for (var j = 0; j < (bossListData["bosses"][i]["npcs"] as JArray).Count; j++)
                {
                    npcs.Add(new Npc
                    {
                        Id = bossListData["bosses"][i]["npcs"][j]["id"],
                        Name = bossListData["bosses"][i]["npcs"][j]["name"],
                        UrlSlug = bossListData["bosses"][i]["npcs"][j]["urlSlug"],
                    });
                }
                Bosses.Add(new Boss
                {
                    Id = bossListData["bosses"][i]["id"],
                    Name = bossListData["bosses"][i]["name"],
                    UrlSlug = bossListData["bosses"][i]["urlSlug"],
                    Description = bossListData["bosses"][i]["description"],
                    ZoneId = bossListData["bosses"][i]["zoneId"],
                    AvailableInNormalMode = bossListData["bosses"][i]["availableInNormalMode"],
                    AvailableInHeroicMode = bossListData["bosses"][i]["availableInHeroicMode"],
                    Health = bossListData["bosses"][i]["health"],
                    HeroicHealth = bossListData["bosses"][i]["heroicHealth"],
                    Level = bossListData["bosses"][i]["level"],
                    HeroicLevel = bossListData["bosses"][i]["heroicLevel"],
                    JournalId = bossListData["bosses"][i]["journalId"],
                    Npcs = npcs
                });
            }
        }
    }
}
