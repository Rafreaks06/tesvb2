using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AppConcertTicket
{
    class AppSettings
    {
        public static IConfiguration Configuration { get; }

        static AppSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string GetConnectionString(string name = "Default")
        {
            return Configuration.GetConnectionString(name);
        }
    }
}
