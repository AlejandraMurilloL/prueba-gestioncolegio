using GestionColegio.Application.Profesores.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Profesores.Services
{
    public interface IProfesorQueryService
    {
        Task<ProfesorDto> GetById(int id);
        Task<IEnumerable<ProfesorDto>> GetAll();
    }
}
