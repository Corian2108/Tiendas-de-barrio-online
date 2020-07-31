using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TiendasOnlineWeb.Areas.Identity.Data;
using TiendasOnlineWeb.Data;

[assembly: HostingStartup(typeof(TiendasOnlineWeb.Areas.Identity.IdentityHostingStartup))]
namespace TiendasOnlineWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TiendasOnlineWebDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TiendasOnlineWebDbContextConnection")));

                services.AddDefaultIdentity<TiendasOnlineWebAppUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<TiendasOnlineWebDbContext>();
            });
        }
    }
}