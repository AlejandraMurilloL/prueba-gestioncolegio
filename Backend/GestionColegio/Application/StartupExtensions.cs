﻿using GestionColegio.Application.Asignaturas.Services;
using GestionColegio.Application.Profesores.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GestionColegio.Application
{
    public static class StartupExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAsignaturaQueryService, AsignaturaQueryService>();
            services.AddScoped<IProfesorQueryService, ProfesorQueryService>();
            services.AddScoped<IProfesorCommandService, ProfesorCommandService>();

            return services;
        }
    }
}
