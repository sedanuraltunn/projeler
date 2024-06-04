namespace HTMLLesson.Helper
{
    public class Configuration
    {
        static public string PostgresConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
        static public string SqlServerConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SqlServer");
            }
        }
    }
}
