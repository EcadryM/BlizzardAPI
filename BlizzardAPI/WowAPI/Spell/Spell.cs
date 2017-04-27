namespace WowAPI.Spell
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Range { get; set; }
        public string PowerCost { get; set; }
        public string CastTime { get; set; }
        public string Cooldown { get; set; }

        public Spell(string spellID, string region, string locale)
        {
            var spellData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/spell/{spellID}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (spellData == null)
                return;

            Id = spellData["id"];
            Name = spellData["name"];
            Icon = spellData["icon"];
            Description = spellData["description"];
            Range = spellData["range"];
            PowerCost = spellData["powerCost"];
            CastTime = spellData["castTime"];
            Cooldown = spellData["cooldown"];
        }
    }
}
