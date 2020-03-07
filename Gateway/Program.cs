﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Gateway
{
    public class Program
    {
        public static IHostingEnvironment HostingEnvironment { get; set; }
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //config.AddJsonFile($"configuration.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration((host, config) =>
            {
                var env = host.HostingEnvironment;
         
                var dsf = $"{env.EnvironmentName}OcelotConfig.json";
                config.AddJsonFile($"{env.EnvironmentName}OcelotConfig.json", true, true);
            })
            .UseStartup<Startup>()
            .UseKestrel((context, options) =>
            {
                var port = Environment.GetEnvironmentVariable("PORT");
                if (!string.IsNullOrEmpty(port))
                {
                    options.ListenAnyIP(int.Parse(port));
                }
            });


    }
}
