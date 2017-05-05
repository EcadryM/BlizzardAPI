using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.DataResources
{
    public class CharacterClasses
    {
        private List<CharacterClass> classes = new List<CharacterClass>();
        public List<CharacterClass> Classes { get => classes; set => classes = value; }
        public CharacterClasses(string region, string locale)
        {
            var classesData = ApiHelper.GetJsonFromUrl(
              $"https://{region}.api.battle.net/wow/data/character/classes?locale={locale}&apikey={ApiHandler.ApiKey}"
          );

            if (classesData == null)
                return;

            for (var i = 0; i < (classesData["classes"] as JArray).Count; i++)
            {
                Classes.Add(new CharacterClass
                {
                    Id = classesData["classes"][i]["id"],
                    Mask = classesData["classes"][i]["mask"],
                    PowerType = classesData["classes"][i]["powerType"],
                    Name = classesData["classes"][i]["name"]
                });
            }
        }
    }
}
