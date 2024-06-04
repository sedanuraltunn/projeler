﻿
namespace HtmlLesson.Helper
{
    public class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MSUConnection");
            }
        }

    }
}
