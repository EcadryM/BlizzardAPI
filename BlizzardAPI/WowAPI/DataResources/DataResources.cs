using System;

namespace WowAPI.DataResources
{
    public class DataResources
    {
        private readonly string region, locale;

        public DataResources(string region, string locale)
        {
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { region, locale });
        }

        public CharacterClasses CharacterClasses()
        {
            return CreateNewInstance(typeof(CharacterClasses)) as CharacterClasses;
        }

        public CharacterRaces CharacterRaces()
        {
            return CreateNewInstance(typeof(CharacterRaces)) as CharacterRaces;
        }

        public GuildPerks GuildPerks()
        {
            return CreateNewInstance(typeof(GuildPerks)) as GuildPerks;
        }

        public PetsTypes PetTypes()
        {
            return CreateNewInstance(typeof(PetsTypes)) as PetsTypes;
        }

        public Battlegroups Battlegroups()
        {
            return CreateNewInstance(typeof(Battlegroups)) as Battlegroups;
        }
    }
}
