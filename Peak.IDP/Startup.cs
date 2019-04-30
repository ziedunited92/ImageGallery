using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Peak.IDP.Entities;
using Peak.IDP.Services;

namespace Peak.IDP
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
           

            var connectionString = Configuration["connectionStrings:peakDBConnectionString"];
            services.AddDbContext<PeakUserContext>(o => o.UseSqlServer(connectionString));
            services.AddDbContext<PeakClientContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<IPeakUserRepository, PeakUserRepository>();
            services.AddScoped<IPeakClientRepository, PeakClientRepository>();
            services.AddMvc();
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddTestUsers(Config.GetUsers())
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILoggerFactory loggerFactory
,PeakUserContext peakUserContext, PeakClientContext peakClientContext)
        {
           


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            
          

            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
