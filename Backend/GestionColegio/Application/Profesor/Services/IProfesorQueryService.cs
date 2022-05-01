using GestionColegio.Application.Profesor.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Profesor.Services
{
    public interface IProfesorQueryService
    {
        Task<ProfesorDto> GetById(int id);
        Task<IEnumerable<ProfesorDto>> GetAll();
    }
}
