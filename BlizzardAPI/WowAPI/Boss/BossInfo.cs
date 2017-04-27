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
            Npcs = bossData["npcs"].ToObject<List<Npc>>();
        }
    }
}
