using GestionColegio.Application.Estudiantes.Dtos;
using System.Threading.Tasks;

namespace GestionColegio.Application.Estudiantes.Services
{
    public interface IEstudianteCommandService
    {
        Task Save(EstudianteDto dto);
        Task Update(EstudianteDto dto, int id);
        Task Delete(int id);
    }
}
