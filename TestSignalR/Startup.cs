using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data;
using TradingPlatformBlazor.Data.Repository;
using TradingPlatformBlazor.Data.Services;

namespace TradingPlatformBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;           
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"));
            });
            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = "Cookies";
                opt.RequireAuthenticatedSignIn = true;
            }).AddCookie(opt => opt.Cookie.Name = "Cookie");
            services.AddSignalR();
            services.AddHttpContextAccessor();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient();

            services.AddSingleton<IEmailingService, Emailing>();
            services.AddSingleton<IUserStatus, UserOnlineStatusRegistry>();

            services.AddScoped<ICategory, SQLCategory>();
            services.AddScoped<ILot, SQLLot>();
            services.AddScoped<IUser, SQLUser>();
            services.AddScoped<IMessage, SQLMessage>();
            services.AddScoped<IOffer, SQLOffer>();
            services.AddScoped<IComment, SQLComment>();
            services.AddScoped<IShop, SQLShop>();
            services.AddScoped<IShopLot, SQLShopLot>();
            services.AddScoped<IMessageShop, SQLMessageShop>();
            services.AddScoped<IAccessToken, SQLAccessToken>();


           
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<OurHub>("/hub");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
