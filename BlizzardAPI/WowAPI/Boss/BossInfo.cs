using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Boss
{
    public class BossInfo : Boss
    {
        public BossInfo(string bossId, string region, string locale)
        {
            var bossData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/boss/{bossId}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (bossData == null)
                return;

            var npcs = new List<Npc>();
            for (var i = 0; i < (bossData["npcs"] as JArray).Count; i++)
            {
                npcs.Add(new Npc
                {
                    Id = bossData["npcs"][i]["id"],
                    Name = bossData["npcs"][i]["name"],
                    UrlSlug = bossData["npcs"][i]["urlSlug"],
                });
            }

            Id = bossData["id"];
            Name = bossData["name"];
            UrlSlug = bossData["urlSlug"];
            Description = bossData["description"];
            ZoneId = bossData["zoneId"];
            AvailableInNormalMode = bossData["availableInNormalMode"];
            AvailableInHeroicMode = bossData["availableInHeroicMode"];
            Health = bossData["health"];
            HeroicHealth = bossData["heroicHealth"];
            Level = bossData["level"];
            HeroicLevel = bossData["heroicLevel"];
            JournalId = bossData["journalId"];
            Npcs = npcs;
        }
    }
}
