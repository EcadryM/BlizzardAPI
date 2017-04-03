using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Professions
    {
        public List<Profession> primary = new List<Profession>();
        public List<Profession> secondary = new List<Profession>();

        public Professions(string name, string realm, string region, string locale)
        {
            var professionsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=professions&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (professionsData == null || professionsData["professions"]["primary"] == null &&
                professionsData["professions"]["secondary"] == null)
                return;

            for (var i = 0; i < (professionsData["professions"]["primary"] as JArray).Count; i++)
            {
                primary.Add(new Profession
                {
                    Id = professionsData["professions"]["primary"][i]["id"],
                    Rank = professionsData["professions"]["primary"][i]["rank"],
                    Max = professionsData["professions"]["primary"][i]["max"],
                    Name = professionsData["professions"]["primary"][i]["name"],
                    Icon = professionsData["professions"]["primary"][i]["icon"],
                    Recipes = professionsData["professions"]["primary"][i]["recipes"].ToObject<int[]>()
                });
            }

            for (var i = 0; i < (professionsData["professions"]["secondary"] as JArray).Count; i++)
            {
                secondary.Add(new Profession
                {
                    Id = professionsData["professions"]["secondary"][i]["id"],
                    Rank = professionsData["professions"]["secondary"][i]["rank"],
                    Max = professionsData["professions"]["secondary"][i]["max"],
                    Name = professionsData["professions"]["secondary"][i]["name"],
                    Icon = professionsData["professions"]["secondary"][i]["icon"],
                    Recipes = professionsData["professions"]["secondary"][i]["recipes"].ToObject<int[]>()
                });
            }
        }
    }
}
