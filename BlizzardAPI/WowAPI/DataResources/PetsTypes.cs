using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.DataResources
{
    public class PetsTypes
    {
        private List<PetType> types = new List<PetType>();
        public List<PetType> Types { get => types; set => types = value; }

        public PetsTypes(string region, string locale)
        {
            var petsTypesData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/data/pet/types?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (petsTypesData == null)
                return;

            for (var i = 0; i < (petsTypesData["petTypes"] as JArray).Count; i++)
            {
                Types.Add(new PetType
                {
                    Id = petsTypesData["petTypes"][i]["id"],
                    Key = petsTypesData["petTypes"][i]["key"],
                    Name = petsTypesData["petTypes"][i]["name"],
                    TypeAbilityId = petsTypesData["petTypes"][i]["typeAbilityId"],
                    StrongAgainstId = petsTypesData["petTypes"][i]["strongAgainstId"],
                    WeakAgainstId = petsTypesData["petTypes"][i]["weakAgainstId"]
                });
            }
        }
    }
}
