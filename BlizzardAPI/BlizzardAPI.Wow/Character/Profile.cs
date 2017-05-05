using System.Text.RegularExpressions;

namespace BlizzardAPI.Wow.Character
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
            var profileData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (profileData == null)
                return;

            LastModified = profileData["lastModified"];

            Class = profileData["class"];
            Race = profileData["race"];
            Gender = profileData["gender"];
            Level = profileData["level"];
            AchievementPoints = profileData["achievementPoints"];
            Faction = profileData["faction"];
            TotalHonorableKills = profileData["totalHonorableKills"];

            Name = profileData["name"];
            Realm = profileData["realm"];

            BattleGroup = profileData["battlegroup"];

            var url = Regex.Match((string)profileData["thumbnail"], ".+-");

            Avatar = $"http://render-{region}.worldofwarcraft.com/character/{url}avatar.jpg";
            Inset = $"http://render-{region}.worldofwarcraft.com/character/{url}inset.jpg";
            ProfileMain = $"http://render-{region}.worldofwarcraft.com/character/{url}profilemain.jpg";
        }
    }
}