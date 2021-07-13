using DBLib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using DBLib.Interfaces;
using DBLib.Managers;

namespace API
{
    public class Startup
    {
        readonly string myOrigins = "myOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IVehicleManager, VehicleManager>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: myOrigins,
                    builder =>
                    {
                        // builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                        builder.WithOrigins("http://localhost:4200", "https://localhost:4200", "https://localhost:5001", "http://localhost:5000")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowAnyOrigin();
                    });
            });

            services.AddDbContext<VsContext>(options =>
            {
                options.UseSqlite("Data Source=VehicleSearch.db");

                //options.UseSqlServer(Configuration.GetConnectionString("VSDB"), 
                //    assembly => assembly.MigrationsAssembly(typeof(VsContext).Assembly.FullName));

            });


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(myOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            try
            {
                DBSeeder.Seed("VehicleSearch_Sample_Data.json", app.ApplicationServices);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
