using System.Collections.Generic;

namespace WowAPI.Pet
{
    public class PetsList
    {
        private List<PetFields> pets = new List<PetFields>();

        public List<PetFields> Pets { get => pets; set => pets = value; }

        public PetsList(string region, string locale)
        {
            var petsListData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/pet/?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsListData == null)
                return;

            Pets = petsListData["pets"].ToObject<List<PetFields>>();
        }
    }
}
