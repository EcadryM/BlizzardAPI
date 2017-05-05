using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlizzardAPI.Wow.Character
{
    public class PetSlots
    {
        private List<Slot> petSlots = new List<Slot>();
        public List<Slot> CharacterPetSlots { get => petSlots; set => petSlots = value; }

        public PetSlots(string name, string realm, string region, string locale)
        {
            var petSlotsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=petSlots&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petSlotsData == null || petSlotsData["petSlots"] == null)
                return;
            
            for (var i = 0; i < (petSlotsData["petSlots"] as JArray).Count; i++)
            {
                CharacterPetSlots.Add(new Slot
                {
                    PetSlot = petSlotsData["petSlots"][i]["slot"],
                    BattlePetGuid = petSlotsData["petSlots"][i]["battlePetGuid"],
                    IsEmpty = petSlotsData["petSlots"][i]["isEmpty"],
                    IsLocked = petSlotsData["petSlots"][i]["isLocked"],
                    Abilities = petSlotsData["petSlots"][i]["abilities"].ToObject<int[]>()
                });
            }
        }
    }
}
