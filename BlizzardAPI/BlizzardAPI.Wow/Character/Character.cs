using System;

namespace BlizzardAPI.Wow.Character
{
    public class Character
    {
        private readonly string name, realm, region, locale;

        public Character(string name, string realm, string region, string locale)
        {
            this.name = name;
            this.realm = realm;
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { name, realm, region, locale });
        }

        public Profile Profile()
        {
            return CreateNewInstance(typeof(Profile)) as Profile;
        }

        public Achievements Achievements()
        {
            return CreateNewInstance(typeof(Achievements)) as Achievements;
        }

        public Appearance Appearance()
        {
            return CreateNewInstance(typeof(Appearance)) as Appearance;
        }

        public Guild Guild()
        {
            return CreateNewInstance(typeof(Guild)) as Guild;
        }

        public Mounts Mounts()
        {
            return CreateNewInstance(typeof(Mounts)) as Mounts;
        }

        public HunterPets HunterPets()
        {
            return CreateNewInstance(typeof(HunterPets)) as HunterPets;
        }

        public Pets Pets()
        {
            return CreateNewInstance(typeof(Pets)) as Pets;
        }

        public PetSlots PetSlots()
        {
            return CreateNewInstance(typeof(PetSlots)) as PetSlots;
        }

        public Professions Professions()
        {
            return CreateNewInstance(typeof(Professions)) as Professions;
        }

        public PvP PvP()
        {
            return CreateNewInstance(typeof(PvP)) as PvP;
        }

        public Quests Quests()
        {
            return CreateNewInstance(typeof(Quests)) as Quests;
        }

        public Reputation Reputation()
        {
            return CreateNewInstance(typeof(Reputation)) as Reputation;
        }

        public Stats Stats()
        {
            return CreateNewInstance(typeof(Stats)) as Stats;
        }

        public Titles Titles()
        {
            return CreateNewInstance(typeof(Titles)) as Titles;
        }

        public Progression Progression()
        {
            return CreateNewInstance(typeof(Progression)) as Progression;
        }

        public Feed Feed()
        {
            return CreateNewInstance(typeof(Feed)) as Feed;
        }

        public Statistics Statistics()
        {
            return CreateNewInstance(typeof(Statistics)) as Statistics;
        }

        public Talents Talents()
        {
            return CreateNewInstance(typeof(Talents)) as Talents;
        }
    }
}
