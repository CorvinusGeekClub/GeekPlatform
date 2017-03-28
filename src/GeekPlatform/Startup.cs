using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using GeekPlatform.Models;

namespace GeekPlatform
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddMvc();

            services.AddDbContext<GeekPlatform.Models.GeekDatabaseContext>(options => {
                string envstring = Configuration.GetConnectionString("defaultConnection");
                options.UseSqlServer(string.IsNullOrEmpty(envstring) ? Configuration.GetConnectionString("GeekDatabase") : envstring);
            });

            services.AddIdentity<Profile, IdentityRole<int>>(options => {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<GeekDatabaseContext, int>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Force SSL in production and staging
            if (env.IsProduction() || env.IsStaging())
            {
                app.Use(async (context, next) => {
                    if (context.Request.IsHttps)
                    {
                        await next();
                    }
                    else
                    {
                        var httpsUrl = "https://" + context.Request.Host + context.Request.Path;
                        context.Response.Redirect(httpsUrl, true);
                    }
                });
            }

#if RESET_DB
            Models.SeedData.Initialize(app.ApplicationServices, true).GetAwaiter().GetResult();
#else
            // reset on staging anyway
            if (env.IsStaging())
            {
                Models.SeedData.Initialize(app.ApplicationServices, true).GetAwaiter().GetResult();
            } else
            {
                Models.SeedData.Initialize(app.ApplicationServices, false).GetAwaiter().GetResult(); ;
            }

#endif

            // app.UseApplicationInsightsExceptionTelemetry();

            app.UseStaticFiles();

            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
