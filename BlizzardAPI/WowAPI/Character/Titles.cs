using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Titles
    {
        public List<Title> titles = new List<Title>();

        public Titles(string name, string realm, string region, string locale)
        {
            var titlesData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=titles&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (titlesData == null || titlesData["titles"] == null)
                return;

            for (var i = 0; i < (titlesData["titles"] as JArray).Count; i++)
            {
                titles.Add(new Title
                {
                    Id = titlesData["titles"][i]["id"],
                    Name = titlesData["titles"][i]["name"]
                });
            }
        }
    }
}
