using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Pets
    {
        public int NumCollected { get; set; }
        public int NumNotCollected { get; set; }

        public List<Pet> collected = new List<Pet>();

        public Pets(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
