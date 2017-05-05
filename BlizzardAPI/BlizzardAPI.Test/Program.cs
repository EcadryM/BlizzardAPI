using BlizzardAPI.Wow;

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
            var characterGuild = character.Guild();
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
            var feed = character.Feed();
            var statistics = character.Statistics();
            var talents = character.Talents();

            var mounts = api.Mounts("us", "en_US");

            var leaderboards = api.Leaderboards("3v3", "us", "en_US");

            var quest = api.Quest("8625", "us", "en_US");

            var recipe = api.Recipe("33994", "us", "en_US");

            var dataResources = api.DataResources("us", "en_US");
            var battlegroups = dataResources.Battlegroups();
            var races = dataResources.CharacterRaces();
            var classes = dataResources.CharacterClasses();
            var guildPerks = dataResources.GuildPerks();
            var petTypes = dataResources.PetTypes();

            var realms = api.Realms("us", "en_US");

            var auction = api.AuctionData("Medivh", "us", "en_US");

            var boss = api.Boss("us", "en_US");
            var bossList = boss.BossList();
            var bossInfo = boss.BossInfo("24723");


            var guild = api.Guild("Medivh", "Shattered Fates", "us", "en_US");
            var guildInfo = guild.GuildInfo();
            var guildMembers = guild.GuildMembers();
            var guildAchievements = guild.GuildAchievements();
            var guildNews = guild.GuildNews();
            var guildChallenge = guild.GuildChallenge();

            var pet = api.Pet("us", "en_US");
            var petsList = pet.PetsList();
            var petAbility = pet.PetAbility("640");
            var petSpecies = pet.PetSpecies("258");
            var petStats = pet.PetStats("258", "40", "5", "4");

            var spell = api.Spell("8056", "us", "en_US");

            var zone = api.Zone("us", "en_US");
            var zoneList = zone.ZoneList();
            var zoneInfo = zone.ZoneInfo("4131");

            var item = api.Item("us", "en_US");
            var itemInfo = item.ItemInfo("18826");
            var itemSet = item.ItemSet("1060");
        }
    }
}
