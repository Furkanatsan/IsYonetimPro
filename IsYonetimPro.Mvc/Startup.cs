using IsYonetimPro.Services.AutoMapper.Profiles;
using IsYonetimPro.Services.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsYonetimPro.Mvc
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();//sen bir Mvc sin KENDÝNE GEL!!!
            services.AddAutoMapper(typeof(TaskProfile),typeof(EmployeeProfile));//typeof(TaskProfile)==derlenme esnasýnda automapperin burdaki sýnýflarý taranmasýný saðlar.
            services.LoadMyServices();//servisler bunun içinde.

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();//sitemizde olmayan bir view a gittiðimizde 404 hatasý vericek.
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();//wwwroot içerisi

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapAreaControllerRoute(
                //    name: "Admin",
                //    areaName: "Admin",
                //    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                //    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
