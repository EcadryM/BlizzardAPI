namespace WowAPI.Pet
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
            var petsListData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/pet/ability/{abilityID}?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (petsListData == null)
                return;

            Id = petsListData["id"];
            Name = petsListData["name"];
            Icon = petsListData["icon"];
            Cooldown = petsListData["cooldown"];
            Rounds = petsListData["rounds"];
            PetTypeId = petsListData["petTypeId"];
            IsPassive = petsListData["isPassive"];
            HideHints = petsListData["hideHints"];
        }
    }
}
