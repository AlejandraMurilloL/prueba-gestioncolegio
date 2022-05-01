using AutoMapper;
using GestionColegio.Application.Asignaturas.Dtos;
using GestionColegio.Application.Profesores.Dtos;
using GestionColegio.Domain.Entities;
using System;

namespace GestionColegio.ObjectMapper.AutoMapper
{
    public class GestionColegioProfile : Profile
    {
        public GestionColegioProfile()
        {
            CreateMap<Asignatura, AsignaturaDto>();
            CreateMap<Profesor, ProfesorDto>();
        }
    }
}
