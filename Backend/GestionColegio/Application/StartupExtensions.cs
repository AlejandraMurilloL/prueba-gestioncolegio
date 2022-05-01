﻿using GestionColegio.Application.Asignatura.Services;
using GestionColegio.Application.Profesor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GestionColegio.Application
{
    public static class StartupExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAsignaturaQueryService, AsignaturaQueryService>();
            services.AddScoped<IProfesorQueryService, ProfesorQueryService>();

            return services;
        }
    }
}
