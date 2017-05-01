using System;

namespace WowAPI.Zone
{
    public class Zone
    {
        private readonly string region, locale;

        public Zone(string region, string locale)
        {
            this.region = region;
            this.locale = locale;
        }

        private object CreateNewInstance(Type type)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { region, locale });
        }

        private object CreateNewInstance(Type type, string zoneId)
        {
            return ApiHelper.CreateNewInstance(type, new object[] { zoneId, region, locale });
        }

        public ZoneList ZoneList()
        {
            return CreateNewInstance(typeof(ZoneList)) as ZoneList;
        }

        public ZoneInfo ZoneInfo(string zoneId)
        {
            return CreateNewInstance(typeof(ZoneInfo), zoneId) as ZoneInfo;
        }
    }
}
