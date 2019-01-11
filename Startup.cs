using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerce
{
    public class Startup
    {
        // Creates a configuration object on startup
        public IConfiguration Configuration { get; }

        // Populates the configuration property with an object on Startup
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Adds Session to the app
            services.AddSession();

            // Adds DBContext to query the DB
            services.AddDbContext<ECommerceContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            
            // Adds MVC service to the app
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Uses Session service in the app
            app.UseSession();

            // Uses static files for product and user images
            app.UseStaticFiles();

            // Uses the MVC serivce in the app
            app.UseMvc();
        }
    }
}
