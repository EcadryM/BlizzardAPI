﻿using System;
using Newtonsoft.Json.Linq;
using System.Net;

namespace BlizzardAPI.Wow
{
    public class ApiHelper
    {
        public static dynamic GetJsonFromUrl(string url)
        {
            try
            {
                return JObject.Parse(new WebClient().DownloadString(url));
            }
            catch { return null; }
        }

        public static object CreateNewInstance(Type type, object[] args)
        {
            return Activator.CreateInstance(type, args);
        }
    }
}
