using GestionColegio.Application;
using GestionColegio.Domain.Interfaces;
using GestionColegio.ObjectMapper.AutoMapper;
using GestionColegio.Persistence.EntityFramework.Context;
using GestionColegio.Persistence.EntityFramework.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Reflection;

namespace GestionColegio.WebApi
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = $"Gestion Colegio v1", Version = "v1" });
            });

            services.AddControllers().AddNewtonsoftJson(); ;

            services.AddDbContext<GestionColegioDbContext>
                (opts => opts.UseSqlServer(Configuration["ConnectionStrings:GestionColegioDB"]));

            services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(new List<Assembly>() { typeof(GestionColegioProfile).Assembly });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.ConfigureServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Gesti�n Colegio API V1");
            });

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
