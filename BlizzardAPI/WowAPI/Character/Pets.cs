using Newtonsoft.Json.Linq;
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
            var petsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=pets&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsData == null)
                return;

            NumCollected = petsData.pets["numCollected"];
            NumNotCollected = petsData.pets["numNotCollected"];

            for (var i = 0; i < (petsData.pets["collected"] as JArray).Count; i++)
            {
                collected.Add(new Pet
                {
                    Name = petsData.pets["collected"][i]["name"],
                    Icon = petsData.pets["collected"][i]["icon"],
                    BattlePetGuid = petsData.pets["collected"][i]["battlePetGuid"],
                    CreatureName = petsData.pets["collected"][i]["creatureName"],
                    SpellId = petsData.pets["collected"][i]["spellId"],
                    CreatureId = petsData.pets["collected"][i]["creatureId"],
                    ItemId = petsData.pets["collected"][i]["itemId"],
                    QualityId = petsData.pets["collected"][i]["qualityId"],
                    IsFavorite = petsData.pets["collected"][i]["isFavorite"],
                    IsFirstAbilitySlotSelected = petsData.pets["collected"][i]["isFirstAbilitySlotSelected"],
                    IsSecondAbilitySlotSelected = petsData.pets["collected"][i]["isSecondAbilitySlotSelected"],
                    IsThirdAbilitySlotSelected = petsData.pets["collected"][i]["isThirdAbilitySlotSelected"],
                    CanBattle = petsData.pets["collected"][i]["canBattle"],

                    pStats = new PetStats
                    {
                        SpeciesId = petsData.pets["collected"][i]["stats"]["speciesId"],
                        BreedId = petsData.pets["collected"][i]["stats"]["breedId"],
                        PetQualityId = petsData.pets["collected"][i]["stats"]["petQualityId"],
                        Level = petsData.pets["collected"][i]["stats"]["level"],
                        Health = petsData.pets["collected"][i]["stats"]["health"],
                        Power = petsData.pets["collected"][i]["stats"]["power"],
                        Speed = petsData.pets["collected"][i]["stats"]["speed"]
                    }
                });
            }
        }
    }
}
