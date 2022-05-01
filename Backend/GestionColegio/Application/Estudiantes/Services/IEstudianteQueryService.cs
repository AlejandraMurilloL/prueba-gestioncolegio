using GestionColegio.Application.Estudiantes.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Estudiantes.Services
{
    public interface IEstudianteQueryService
    {
        Task<IEnumerable<EstudianteDto>> GetAll();
        Task<EstudianteDto> GetById(int id);
    }
}
