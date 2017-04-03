namespace WowAPI.Character
{
    class Appearance
    {
        public int FaceVariation { get; set; }
        public int SkinColor { get; set; }
        public int HairVariation { get; set; }
        public int HairColor { get; set; }
        public int FeatureVariation { get; set; }

        public bool ShowHelm { get; set; }
        public bool ShowCloak { get; set; }

        public int[] pCustomDisplayOptions { get; set; }

        public Appearance(string name, string realm, string region, string locale)
        {
            // TODO: Get the JSON file from the URL of the api request and initialize the properties with json objects values.
        }
    }
}
