using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Professions
    {
        private List<Profession> primary = new List<Profession>();
        private List<Profession> secondary = new List<Profession>();

        public List<Profession> Primary { get => primary; set => primary = value; }
        public List<Profession> Secondary { get => secondary; set => secondary = value; }

        public Professions(string name, string realm, string region, string locale)
        {
            var professionsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=professions&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (professionsData == null || professionsData["professions"]["primary"] == null &&
                professionsData["professions"]["secondary"] == null)
                return;

            Primary = professionsData["professions"]["primary"].ToObject<List<Profession>>();
            Secondary = professionsData["professions"]["secondary"].ToObject<List<Profession>>();
        }
    }
}
