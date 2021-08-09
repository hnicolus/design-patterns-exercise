using System;
using System.Collections.Generic;

namespace Patterns.Singleton.ConfigManager
{
    public class ConfigurationManager
    {
        private Dictionary<string,Object> configurations  = new();
        private static ConfigurationManager configManager = new();
        private ConfigurationManager(){}

        public static ConfigurationManager GetInstance()=> configManager;
        public void Set(string key, object value)
        {
            configurations.Add(key,value);
        }

        public Object get(string key)
        {
            if(!configurations.ContainsKey(key))return null;
            return configurations[key];
        }
    }
}