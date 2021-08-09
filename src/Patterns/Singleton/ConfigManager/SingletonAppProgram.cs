using System;

namespace Patterns.Singleton.ConfigManager
{
    public static class SingletonAppProgram
    {
        public static void Run ()
        {
            var configManager =  ConfigurationManager.GetInstance();
            
            configManager.Set("firstName", "Nicolas");
            configManager.Set("lastName", "Maluleke");

            //some where else in them prrogram if you want to access the uses information;

            var configManager1 = ConfigurationManager.GetInstance();
            var firstName =  configManager1.get("firstName");
            var lastName = configManager1.get("lastName");
            Console.WriteLine($"Name : {firstName}\nSurname : {lastName}");
            
        }
    }
}