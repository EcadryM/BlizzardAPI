namespace WowAPI.Character
{
    public class Profile
    {
        public long LastModified { get; set; }

        public int Class { get; set; }
        public int Race { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public int Faction { get; set; }
        public int TotalHonorableKills { get; set; }

        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public string Avatar { get; set; }
        public string Inset { get; set; }
        public string ProfileMain { get; set; }

        public Profile(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}