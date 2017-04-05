namespace WowAPI.Quest
{
    public class Quest
    {
        public int Id { get; set; }
        public int ReqLevel { get; set; }
        public int SuggestedPartyMembers { get; set; }
        public int Level { get; set; }

        public string Title { get; set; }
        public string Category { get; set; }

        public Quest(string questId, string region, string locale)
        {
            var questData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/quest/{questId}?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (questData == null)
                return;

            Id = questData["id"];
            ReqLevel = questData["reqLevel"];
            SuggestedPartyMembers = questData["suggestedPartyMembers"];
            Level = questData["level"];
            Title = questData["title"];
            Category = questData["category"];
        }
    }
}
