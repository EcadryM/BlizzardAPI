using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WowAPI.Character
{
    public class PetSlots
    {
        public List<Slot> petSlots = new List<Slot>();

        public PetSlots(string name, string realm, string region, string locale)
        {
            var petSlotsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=petSlots&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petSlotsData == null || petSlotsData["petSlots"] == null)
                return;
            
            for (var i = 0; i < (petSlotsData["petSlots"] as JArray).Count; i++)
            {
                petSlots.Add(new Slot
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
