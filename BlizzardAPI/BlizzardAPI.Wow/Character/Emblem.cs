namespace BlizzardAPI.Wow.Character
{
    public class Emblem
    {
        public int Icon { get; set; }
        public int IconColorId { get; set; }
        public int Border { get; set; }
        public int BorderColorId { get; set; }
        public int BackgroundColorId { get; set; }

        public string IconColor { get; set; }
        public string BorderColor { get; set; }
        public string BackgroundColor { get; set; }
    }
}
