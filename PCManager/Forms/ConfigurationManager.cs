using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PCManager.Forms
{
    public class ConfigurationManager
    {
        public IConfiguration Configuration { get; set; }  

        public void AddConfiguration()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }
}
