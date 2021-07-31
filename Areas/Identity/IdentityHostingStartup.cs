using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rocket_Elevators_Customer_Portal.Areas.Identity.Data;

[assembly: HostingStartup(typeof(Rocket_Elevators_Customer_Portal.Areas.Identity.IdentityHostingStartup))]
namespace Rocket_Elevators_Customer_Portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                // services.AddDbContext<Rocket_Elevators_Customer_PortalIdentityDbContext>(options =>
                //     options.UseSqlServer(
                //         context.Configuration.GetConnectionString("Rocket_Elevators_Customer_PortalIdentityDbContextConnection")));

                // Replace with your connection string.
                var connectionString = "server=codeboxx.cq6zrczewpu2.us-east-1.rds.amazonaws.com;user=codeboxx;password=Codeboxx1!;database=AmirPortal";

                // Replace with your server version and type.
                // Use 'MariaDbServerVersion' for MariaDB.
                // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
                // For common usages, see pull request #1233.
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));

                // Replace 'YourDbContext' with the name of your own DbContext derived class.
                services.AddDbContext<Rocket_Elevators_Customer_PortalIdentityDbContext>(
                    dbContextOptions => dbContextOptions
                        .UseMySql(connectionString, serverVersion)
                        .EnableSensitiveDataLogging() // <-- These two calls are optional but help
                        .EnableDetailedErrors()       // <-- with debugging (remove for production).
                );
                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Rocket_Elevators_Customer_PortalIdentityDbContext>();
            });
        }
    }
}