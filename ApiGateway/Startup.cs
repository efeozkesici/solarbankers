using MarketMicroservice.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System;

namespace ApiGateway
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("service.json")
                .Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddOcelot(_config);

            services.AddDbContext<AppDbContext>();

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //            name: "index.html",
            //            template: "{controller}/{action=Index}/{id?}"
            //        );
            //});

            await app.UseOcelot();
        }
    }
}
