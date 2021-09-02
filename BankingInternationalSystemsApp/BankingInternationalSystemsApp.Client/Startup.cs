using AspNetCoreHero.ToastNotification;
using BankingInternationalSystemsApp.Manager;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Repository;
using BankingInternationalSystemsApp.Repository.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddNotyf(config => {
                config.DurationInSeconds = 5;
                config.IsDismissable = true;
                config.Position = NotyfPosition.BottomRight;
            });

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();

            services.AddScoped<IAccountManager, AccountManager>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountRoleManager, AccountRoleManager>();
            services.AddScoped<IAccountRoleRepository, AccountRoleRepository>();
            services.AddScoped<IWithdrawAccountManager, WithdrawAccountManager>();
            services.AddScoped<IWithdrawAccountRepository, WithdrawAccountRepository>();
            services.AddScoped<ILodgeAccountManager, LodgeAccountManager>();
            services.AddScoped<ILodgeAccountRepository, LodgeAccountRepository>();  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
