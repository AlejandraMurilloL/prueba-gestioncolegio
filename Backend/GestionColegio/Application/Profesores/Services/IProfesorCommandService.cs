using GestionColegio.Application.Profesores.Dtos;
using System.Threading.Tasks;

namespace GestionColegio.Application.Profesores.Services
{
    public interface IProfesorCommandService
    {
        Task Save(ProfesorDto profesor);
        Task Update(ProfesorDto dto, int id);
        Task Delete(int id);
    }
}
