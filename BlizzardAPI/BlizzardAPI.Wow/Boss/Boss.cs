using System;

namespace BlizzardAPI.Wow.Boss
{
    public class Boss
    {
        private readonly string region, locale;

        public Boss(string region, string locale)
        {
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { region, locale });
        }

        private object CreateNewInstance(Type type, string bossId)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { bossId, region, locale });
        }

        public BossList BossList()
        {
            return CreateNewInstance(typeof(BossList)) as BossList;
        }

        public BossInfo BossInfo(string bossId)
        {
            return CreateNewInstance(typeof(BossInfo), bossId) as BossInfo;
        }
    }
}
