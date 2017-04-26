using System.Collections.Generic;

namespace WowAPI.Pet
{
    public class PetSpecies
    {
        public int SpeciesId { get; set; }
        public int PetTypeId { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public bool CanBattle { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public List<Ability> Abilities { get; set; }

        public PetSpecies(string speciesID, string region, string locale)
        {
            var petsSpeciesData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/pet/species/{speciesID}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (petsSpeciesData == null)
                return;

            SpeciesId = petsSpeciesData["speciesId"];
            PetTypeId = petsSpeciesData["petTypeId"];
            CreatureId = petsSpeciesData["creatureId"];
            Name = petsSpeciesData["name"];
            CanBattle = petsSpeciesData["canBattle"];
            Icon = petsSpeciesData["icon"];
            Description = petsSpeciesData["description"];
            Source = petsSpeciesData["source"];
            Abilities = petsSpeciesData["abilities"].ToObject<List<Ability>>();
        }
    }
}
