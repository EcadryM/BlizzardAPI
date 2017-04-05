using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Character
{
    public class HunterPets
    {
        private List<HunterPet> hunterPets = new List<HunterPet>();
        public List<HunterPet> CharacterHunterPets { get => hunterPets; set => hunterPets = value; }

        public HunterPets(string name, string realm, string region, string locale)
        {
            var hunterPetsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=hunterPets&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (hunterPetsData == null || hunterPetsData["hunterPets"] == null)
                return;
            for (var i = 0; i < (hunterPetsData["hunterPets"] as JArray).Count; i++)
            {
                CharacterHunterPets.Add(new HunterPet
                {
                    Creature = hunterPetsData["hunterPets"][i]["creature"],
                    Slot = hunterPetsData["hunterPets"][i]["slot"],
                    FamilyId = hunterPetsData["hunterPets"][i]["familyId"],
                    Name = hunterPetsData["hunterPets"][i]["name"],
                    CalcSpec = hunterPetsData["hunterPets"][i]["calcSpec"],
                    FamilyName = hunterPetsData["hunterPets"][i]["familyName"],
                    Spec = hunterPetsData["hunterPets"][i]["spec"] == null ? new Spec { HasSpec = 0 } : new Spec
                    {
                        HasSpec = 1,
                        Name = hunterPetsData["hunterPets"][i]["spec"]["name"],
                        Role = hunterPetsData["hunterPets"][i]["spec"]["role"],
                        BackgroundImage = hunterPetsData["hunterPets"][i]["spec"]["backgroundImage"],
                        Icon = hunterPetsData["hunterPets"][i]["spec"]["icon"],
                        Description = hunterPetsData["hunterPets"][i]["spec"]["description"],
                        Order = hunterPetsData["hunterPets"][i]["spec"]["order"]
                    }
                });
            }
        }
    }
}
