using System;

namespace WowAPI.Pet
{
    public class Pet
    {
        private readonly string region, locale;

        public Pet(string region, string locale)
        {
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { region, locale });
        }

        private object CreateNewInstance(Type type, string id)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { id, region, locale });
        }

        private object CreateNewInstance(Type type, string speciesID, string level, string breedID, string qualityID)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { speciesID, level, breedID, qualityID, region, locale });
        }

        public PetsList PetsList()
        {
            return CreateNewInstance(typeof(PetsList)) as PetsList;
        }

        public PetAbility PetAbility(string abilityId)
        {
            return CreateNewInstance(typeof(PetAbility), abilityId) as PetAbility;
        }

        public PetSpecies PetSpecies(string speciesId)
        {
            return CreateNewInstance(typeof(PetSpecies), speciesId) as PetSpecies;
        }

        public PetStats PetStats(string speciesID, string level, string breedID, string qualityID)
        {
            return CreateNewInstance(typeof(PetStats), speciesID, level, breedID, qualityID) as PetStats;
        }
    }
}
