using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SportsCompany.FitnessTracker.Endurance.BoundedContext;
using SportsCompany.FitnessTracker.Endurance.WinEnvironment;
using SportsCompany.FitnessTracker.Peripherals.BoundedContext;
using Unity;

namespace SportsCompany.FitnessTracker.Endurance.WebApi
{
    /// <summary>
    /// Start up class for the ASP.NET core WebAPI project.
    /// </summary>
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SportsCompany.FitnessTracker.Endurance.WebApi", Version = "v1" });
            });

            var unityContainer = new UnityContainer();

            EnduranceBoundedContextInitializer.Init(unityContainer);
            EnduranceWinInitializer.Init(unityContainer);
            PeripheralBoundedContextInitializer.Init(unityContainer);

            services.AddSingleton<IUnityContainer>(unityContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SportsCompany.FitnessTracker.Endurance.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
