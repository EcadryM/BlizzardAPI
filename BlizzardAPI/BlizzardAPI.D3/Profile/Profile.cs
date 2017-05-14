using System;

namespace BlizzardAPI.D3.Profile
{
    public class Profile
    {
        private readonly string battleTag, region, locale;

        public Profile(string battleTag, string region, string locale)
        {
            this.battleTag = battleTag;
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { battleTag, region, locale });
        }

        public ProfileInfo ProfileInfo()
        {
            return CreateNewInstance(typeof(ProfileInfo)) as ProfileInfo;
        }
    }
}
