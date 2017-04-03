namespace WowAPI.Character
{
    public class Guild
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public string Members { get; set; }
        public string AchievementPoints { get; set; }

        public Emblem Emblem { get; set; }

        public Guild(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
