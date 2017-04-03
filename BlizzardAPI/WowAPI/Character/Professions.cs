using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Professions
    {
        public List<Profession> primary = new List<Profession>();
        public List<Profession> secondary = new List<Profession>();

        public Professions(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
