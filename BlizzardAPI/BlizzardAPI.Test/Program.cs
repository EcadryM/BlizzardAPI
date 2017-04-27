using WowAPI;

namespace BlizzardAPI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ApiHandler("Enter your api key here");

            var character = api.Character("Rubyslays", "Medivh", "us", "en_US");
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

            var recipe = api.Recipe("33994", "us", "en_US");

            var battlegroups = api.Battlegroups("us", "en_US");
            var races = api.Races("us", "en_US");
            var classes = api.Classes("us", "en_US");
            var guildPerks = api.GuildPerks("us", "en_US");
            var petsTypes = api.PetsTypes("us", "en_US");

            var realms = api.Realms("us", "en_US");

            var auction = api.AuctionData("Medivh", "us", "en_US");

            var bossList = api.BossList("us", "en_US");
            var bossInfo = api.BossInfo("24723", "us", "en_US");

            var guildInfo = api.GuildInfo("Medivh", "Distinct Advantage", "us", "en_US");
            var guildMembers = api.GuildMembers("Medivh", "Distinct Advantage", "us", "en_US");
            var guildAchievements = api.GuildAchievements("Medivh", "Distinct Advantage", "us", "en_US");
            var guildNews = api.GuildNews("Medivh", "Shattered Fates", "us", "en_US");
            var guildChallenge = api.GuildChallenge("Medivh", "Shattered Fates", "us", "en_US");

            var petsList = api.PetsList("us", "en_US");
            var petAbility = api.PetAbility("640", "us", "en_US");
            var petSpecies = api.PetSpecies("258", "us", "en_US");
            var petStats = api.PetStats("258", "40", "5", "4", "us", "en_US");

            var spell = api.Spell("8056", "us", "en_US");

            var zoneList = api.ZoneList("us", "en_US");
            var zoneInfo = api.ZoneInfo("4131", "us", "en_US");
        }
    }
}
