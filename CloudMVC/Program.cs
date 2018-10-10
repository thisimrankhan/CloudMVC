﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using CloudMVC.Infrastructure.Data;
using System;
using Microsoft.Extensions.Logging;
using CloudMVC.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace CloudMVC.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args)
                        .Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var catalogContext = services.GetRequiredService<CloudContext>();
                    CloudContextSeed.SeedAsync(catalogContext, loggerFactory).Wait();

                    //var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    //AppIdentityDbContextSeed.SeedAsync(userManager).Wait();
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://0.0.0.0:5106")
                .UseStartup<Startup>();
    }
}
