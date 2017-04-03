using WowAPI;

namespace BlizzardAPI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ApiHandler("Enter your api key here");

            var character = api.Character("Siege", "Silvermoon", "eu", "en_GB");
            var profile = character.Profile();
            var achievements = character.Achievements();
            var appearance = character.Appearance();
            var guild = character.Guild();
            var mounts = character.Mounts();
        }
    }
}
