using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Logistics.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            //CreateWebhostBuilder ( args ).Build ( ).RunAsService ( );
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5008")
                .UseStartup<Startup>()
                .Build();

        public static IWebHostBuilder CreateWebhostBuilder(string[] args)
        {
            var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
            var pathToContentRoot = Path.GetDirectoryName(pathToExe);
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5008")
                .ConfigureAppConfiguration((context, config) =>
                {
                    //config app here
                })
                .UseContentRoot(pathToContentRoot)
                .UseStartup<Startup>();
        }
    }
}
