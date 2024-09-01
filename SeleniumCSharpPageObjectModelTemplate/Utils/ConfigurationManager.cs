using Microsoft.Extensions.Configuration;
using System.IO;

namespace SeleniumCSharpPageObjectModelTemplate.Utils
{
    class ConfigurationManager
    {
        public IConfigurationRoot Configuration { get; private set; }

        public ConfigurationManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public string GetConfigValue(string key)
        {
            return Configuration[key];
        }
    }
}