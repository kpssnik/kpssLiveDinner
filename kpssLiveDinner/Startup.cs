using kpssLiveDinner.Domain;
using kpssLiveDinner.Domain.Repositories.Abstract;
using kpssLiveDinner.Domain.Repositories.EntityFramework;
using kpssLiveDinner.Services;
using Microsoft.AspNetCore.Builder;
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

namespace kpssLiveDinner
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
      
  
        public void ConfigureServices(IServiceCollection services)
        {
            // Connecting config from appsettings.json
            Configuration.Bind("Project", new Config());

            // Connecting needed app functionality as services
            services.AddTransient<IBlogItemsRepository, EfBlogItemsRepository>();
            services.AddTransient<ICustomerReviewsRepository, EfCustomerReviewsRepository>();
            services.AddTransient<IGalleryImagesRepository, EfGalleryImagesRepository>();
            services.AddTransient<IStuffItemsRepository, EfStuffItemsRepository>();
            services.AddTransient<DataManager>();

            // Add controllers and views supporting (MVC)
            services.AddControllersWithViews();

            // Connecting context DB
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();        
         
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
