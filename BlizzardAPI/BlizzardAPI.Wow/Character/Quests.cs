namespace BlizzardAPI.Wow.Character
{
    public class Quests
    {
        public int[] CharacterQuests { get; set; }

        public Quests(string name, string realm, string region, string locale)
        {
            var questsData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=quests&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (questsData == null)
                return;

            CharacterQuests = questsData["quests"].ToObject<int[]>();
        }
    }
}
