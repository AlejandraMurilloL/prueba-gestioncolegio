using AutoMapper;
using GestionColegio.Application.Asignatura.Dtos;
using GestionColegio.Application.Profesor.Dtos;
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
