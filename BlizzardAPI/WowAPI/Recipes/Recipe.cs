namespace WowAPI.Recipes
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Profession { get; set; }
        public string Icon { get; set; }

        public Recipe(string recipeId, string region, string locale)
        {
            var recipeData = ApiHelper.GetJsonFromUrl(
               $"https://{region}.api.battle.net/wow/recipe/{recipeId}?locale={locale}&apikey={ApiHandler.ApiKey}"
           );

            if (recipeData == null)
                return;

            Id = recipeData["id"];
            Name = recipeData["name"];
            Profession = recipeData["profession"];
            Icon = recipeData["icon"];
        }
    }
}
