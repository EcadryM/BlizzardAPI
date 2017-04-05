using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WowAPI.Character
{
    public class Progression
    {
        private List<Raid> raids = new List<Raid>();
        public List<Raid> Raids { get => raids; set => raids = value; }

        public Progression(string name, string realm, string region, string locale)
        {
            var professionsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=progression&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (professionsData == null || professionsData["progression"]["raids"] == null)
                return;

            for (var i = 0; i < (professionsData["progression"]["raids"] as JArray).Count; i++)
            {
                var bosses = new List<Boss>();
                for (var j = 0; j < (professionsData["progression"]["raids"][i]["bosses"] as JArray).Count; j++)
                {
                    bosses.Add(new Boss
                    {
                        Id = professionsData["progression"]["raids"][i]["bosses"][j]["id"],
                        Name = professionsData["progression"]["raids"][i]["bosses"][j]["name"],
                        NormalKills = professionsData["progression"]["raids"][i]["bosses"][j]["normalKills"],
                        NormalTimestamp = professionsData["progression"]["raids"][i]["bosses"][j]["normalTimestamp"]
                    });
                }
                Raids.Add(new Raid
                {
                    Id = professionsData["progression"]["raids"][i]["id"],
                    Name = professionsData["progression"]["raids"][i]["name"],
                    Lfr = professionsData["progression"]["raids"][i]["lfr"],
                    Normal = professionsData["progression"]["raids"][i]["normal"],
                    Heroic = professionsData["progression"]["raids"][i]["heroic"],
                    Mythic = professionsData["progression"]["raids"][i]["mythic"],
                    Bosses = bosses
                });
            }
        }
    }
}
