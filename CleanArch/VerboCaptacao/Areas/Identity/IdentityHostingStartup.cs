using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VerboCaptacao.Data;

[assembly: HostingStartup(typeof(VerboCaptacao.Areas.Identity.IdentityHostingStartup))]
namespace VerboCaptacao.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VerboCaptacaoContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VerboCaptacaoContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VerboCaptacaoContext>();
            });
        }
    }
}