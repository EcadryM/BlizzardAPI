namespace BlizzardAPI.Wow.Pet
{
    public class PetStats
    {
        public int SpeciesId { get; set; }
        public int BreedId { get; set; }
        public int PetQualityId { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }

        public PetStats(string speciesID, string level, string breedID, string qualityID, string region, string locale)
        {
            var petsStatsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/pet/stats/{speciesID}?level={level}&breedId={breedID}&qualityId={qualityID}&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsStatsData == null)
                return;

            SpeciesId = petsStatsData["speciesId"];
            BreedId = petsStatsData["breedId"];
            PetQualityId = petsStatsData["petQualityId"];
            Level = petsStatsData["level"];
            Health = petsStatsData["health"];
            Power = petsStatsData["power"];
            Speed = petsStatsData["speed"];
        }
    }
}
