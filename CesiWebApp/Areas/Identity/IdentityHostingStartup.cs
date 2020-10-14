using System;
using CesiWebApp.Areas.Identity.Data;
using CesiWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CesiWebApp.Areas.Identity.IdentityHostingStartup))]
namespace CesiWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CesiWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CesiWebAppContextConnection")));

                services.AddDefaultIdentity<CesiWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CesiWebAppContext>();
            });
        }
    }
}