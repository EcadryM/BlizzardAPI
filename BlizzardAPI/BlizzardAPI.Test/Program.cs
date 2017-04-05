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
            var characterMounts = character.Mounts();
            var hunterPets = character.HunterPets();
            var pets = character.Pets();
            var petSlots = character.PetSlots();
            var professions = character.Professions();
            var pvp = character.PvP();
            var quests = character.Quests();
            var reputation = character.Reputation();
            var stats = character.Stats();
            var titles = character.Titles();
            var progression = character.Progression();

            var mounts = api.Mounts("us", "en_US");

            var leaderboards = api.Leaderboards("3v3", "us", "en_US");

            var quest = api.Quest("8625", "us", "en_US");
        }
    }
}
