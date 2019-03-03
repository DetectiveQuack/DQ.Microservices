using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace DQ.ApiBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args);

            builder
                .ConfigureServices(s => s.AddSingleton(builder))
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile(Path.Join("configuration", "configuration.json"));
                })
                .UseStartup<Startup>();

            return builder;
        }
    }
}
