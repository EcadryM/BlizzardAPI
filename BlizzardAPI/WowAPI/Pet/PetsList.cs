using System.Collections.Generic;

namespace WowAPI.Pet
{
    public class PetsList
    {
        private List<Pet> pets = new List<Pet>();

        public List<Pet> Pets { get => pets; set => pets = value; }

        public PetsList(string region, string locale)
        {
            var petsListData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/pet/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsListData == null)
                return;

            Pets = petsListData["pets"].ToObject<List<Pet>>();
        }
    }
}
