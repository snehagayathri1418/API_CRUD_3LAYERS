using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NEXTURN.BUSINESS;
using NEXTURN.BUSINESS.Interface;
using NEXTURN.REPOSITORY;
using NEXTURN.REPOSITORY.Interface;
using NEXTURN.REPOSITORY.Models;
using NEXTURN.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTURN.MVC
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
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<NexturnContext>(options => options.UseSqlServer(connectionString));

            services.AddSession();
            services.AddTransient<ITraineeBusiness, TraineeBusiness>();
            services.AddTransient<ITraineeRepository, TraineeRepository>();
            services.AddControllersWithViews();
            services.AddHttpClient();
            services.AddMemoryCache();


            //Automapper
            services.AddAutoMapper(typeof(AutoMappingConfig));


            services.AddControllersWithViews();

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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Trainee}/{action=Display}/{id?}");
            });
        }
    }
}
