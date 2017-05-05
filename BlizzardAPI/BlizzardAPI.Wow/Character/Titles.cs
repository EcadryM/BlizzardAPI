using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.Character
{
    public class Titles
    {
        private List<Title> titles = new List<Title>();
        public List<Title> CharacterTitles { get => titles; set => titles = value; }

        public Titles(string name, string realm, string region, string locale)
        {
            var titlesData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=titles&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (titlesData == null || titlesData["titles"] == null)
                return;

            for (var i = 0; i < (titlesData["titles"] as JArray).Count; i++)
            {
                CharacterTitles.Add(new Title
                {
                    Id = titlesData["titles"][i]["id"],
                    Name = titlesData["titles"][i]["name"]
                });
            }
        }
    }
}
