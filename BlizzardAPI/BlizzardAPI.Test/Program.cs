namespace BlizzardAPI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BlizzardAPI.Wow

            var wowApi = new Wow.ApiHandler("Enter your api key here");

            var character = wowApi.Character("Rubyslays", "Medivh", "us", "en_US");
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

            var mounts = wowApi.Mounts("us", "en_US");

            var leaderboards = wowApi.Leaderboards("3v3", "us", "en_US");

            var quest = wowApi.Quest("8625", "us", "en_US");

            var recipe = wowApi.Recipe("33994", "us", "en_US");

            var dataResources = wowApi.DataResources("us", "en_US");
            var battlegroups = dataResources.Battlegroups();
            var races = dataResources.CharacterRaces();
            var classes = dataResources.CharacterClasses();
            var guildPerks = dataResources.GuildPerks();
            var petTypes = dataResources.PetTypes();

            var realms = wowApi.Realms("us", "en_US");

            var auction = wowApi.AuctionData("Medivh", "us", "en_US");

            var boss = wowApi.Boss("us", "en_US");
            var bossList = boss.BossList();
            var bossInfo = boss.BossInfo("24723");


            var guild = wowApi.Guild("Medivh", "Shattered Fates", "us", "en_US");
            var guildInfo = guild.GuildInfo();
            var guildMembers = guild.GuildMembers();
            var guildAchievements = guild.GuildAchievements();
            var guildNews = guild.GuildNews();
            var guildChallenge = guild.GuildChallenge();

            var pet = wowApi.Pet("us", "en_US");
            var petsList = pet.PetsList();
            var petAbility = pet.PetAbility("640");
            var petSpecies = pet.PetSpecies("258");
            var petStats = pet.PetStats("258", "40", "5", "4");

            var spell = wowApi.Spell("8056", "us", "en_US");

            var zone = wowApi.Zone("us", "en_US");
            var zoneList = zone.ZoneList();
            var zoneInfo = zone.ZoneInfo("4131");

            var item = wowApi.Item("us", "en_US");
            var itemInfo = item.ItemInfo("18826");
            var itemSet = item.ItemSet("1060");

            #endregion

            #region BlizzardAPI.SC2

            var sc2API = new SC2.ApiHandler("Enter your api key here");

            var sc2Profile = sc2API.Profile("499484", "TheSkunk", "us", "1", "en_US");
            var sc2ProfileInfo = sc2Profile.ProfileInfo();
            var sc2Ladders = sc2Profile.Ladders();
            var sc2MatchHistory = sc2Profile.MatchHistory();

            var sc2Ladder = sc2API.Ladder("194163", "us", "en_US");

            #endregion
        }
    }
}
