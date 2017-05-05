namespace BlizzardAPI.Wow.Character
{
    public class Profession
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public int Max { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int[] Recipes { get; set; }
    }
}
