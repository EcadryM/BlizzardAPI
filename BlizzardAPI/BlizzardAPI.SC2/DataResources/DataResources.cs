using System;

namespace BlizzardAPI.SC2.DataResources
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

        public Achievements Achievements()
        {
            return CreateNewInstance(typeof(Achievements)) as Achievements;
        }

        public Rewards Rewards()
        {
            return CreateNewInstance(typeof(Rewards)) as Rewards;
        }
    }
}
