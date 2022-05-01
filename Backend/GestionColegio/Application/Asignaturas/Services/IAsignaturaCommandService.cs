using GestionColegio.Application.Asignaturas.Dtos;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignaturas.Services
{
    public interface IAsignaturaCommandService
    {
        Task Save(AsignaturaDto profesor);
        Task Update(AsignaturaDto dto, int id);
        Task Delete(int id);
    }
}
