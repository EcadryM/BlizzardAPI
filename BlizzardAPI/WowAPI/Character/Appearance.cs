namespace WowAPI.Character
{
    public class Appearance
    {
        public int FaceVariation { get; set; }
        public int SkinColor { get; set; }
        public int HairVariation { get; set; }
        public int HairColor { get; set; }
        public int FeatureVariation { get; set; }

        public bool ShowHelm { get; set; }
        public bool ShowCloak { get; set; }

        public int[] CustomDisplayOptions { get; set; }

        public Appearance(string name, string realm, string region, string locale)
        {
            var appearanceData = ApiHelper.GetJsonFromUrl(
                $"https://{region}.api.battle.net/wow/character/{realm}/{name}?fields=appearance&locale={locale}&apikey={ApiHandler.ApiKey}"
            );

            if (appearanceData == null)
                return;

            FaceVariation = appearanceData.appearance["faceVariation"];
            SkinColor = appearanceData.appearance["skinColor"];
            HairVariation = appearanceData.appearance["hairVariation"];
            HairColor = appearanceData.appearance["hairColor"];
            FeatureVariation = appearanceData.appearance["featureVariation"];
            ShowHelm = appearanceData.appearance["showHelm"];
            ShowCloak = appearanceData.appearance["showCloak"];
            CustomDisplayOptions = appearanceData.appearance["customDisplayOptions"].ToObject<int[]>();
        }
    }
}
