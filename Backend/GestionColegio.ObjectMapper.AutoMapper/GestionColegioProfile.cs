using AutoMapper;
using GestionColegio.Application.Asignaturas.Dtos;
using GestionColegio.Application.Estudiantes.Dtos;
using GestionColegio.Application.Profesores.Dtos;
using GestionColegio.Domain.Entities;

namespace GestionColegio.ObjectMapper.AutoMapper
{
    public class GestionColegioProfile : Profile
    {
        public GestionColegioProfile()
        {
            CreateMap<Asignatura, AsignaturaDto>();
            CreateMap<AsignaturaDto, Asignatura>();
            CreateMap<Profesor, ProfesorDto>();
            CreateMap<Estudiante, EstudianteDto>();
        }
    }
}
