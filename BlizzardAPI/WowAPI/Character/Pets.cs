using System.Collections.Generic;

namespace WowAPI.Character
{
    public class Pets
    {
        public int NumCollected { get; set; }
        public int NumNotCollected { get; set; }
        public List<Pet> Collected { get => collected; set => collected = value; }

        private List<Pet> collected = new List<Pet>();

        public Pets(string name, string realm, string region, string locale)
        {
            var petsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=pets&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsData == null)
                return;

            NumCollected = petsData.pets["numCollected"];
            NumNotCollected = petsData.pets["numNotCollected"];
            Collected = petsData.pets["collected"].ToObject<List<Pet>>();
        }
    }
}
