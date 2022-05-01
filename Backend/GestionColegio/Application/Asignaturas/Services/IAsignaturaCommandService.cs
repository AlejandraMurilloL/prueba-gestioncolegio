using GestionColegio.Application.Asignaturas.Dtos;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignaturas.Services
{
    public interface IAsignaturaCommandService
    {
        Task Save(AsignaturaDto dto);
        Task Update(AsignaturaDto dto, int id);
        Task Delete(int id);
    }
}
