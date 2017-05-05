namespace BlizzardAPI.Wow.Pet
{
    public class PetAbility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Cooldown { get; set; }
        public int Rounds { get; set; }
        public int PetTypeId { get; set; }
        public bool IsPassive { get; set; }
        public bool HideHints { get; set; }

        public PetAbility(string abilityID, string region, string locale)
        {
            var petsAbilityData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/pet/ability/{abilityID}?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsAbilityData == null)
                return;

            Id = petsAbilityData["id"];
            Name = petsAbilityData["name"];
            Icon = petsAbilityData["icon"];
            Cooldown = petsAbilityData["cooldown"];
            Rounds = petsAbilityData["rounds"];
            PetTypeId = petsAbilityData["petTypeId"];
            IsPassive = petsAbilityData["isPassive"];
            HideHints = petsAbilityData["hideHints"];
        }
    }
}
