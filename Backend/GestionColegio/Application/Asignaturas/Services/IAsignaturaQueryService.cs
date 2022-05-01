using GestionColegio.Application.Asignaturas.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignaturas.Services
{
    public interface IAsignaturaQueryService
    {
        Task<IEnumerable<AsignaturaDto>> GetAll();
    }
}
