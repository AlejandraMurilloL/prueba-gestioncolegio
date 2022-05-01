using System.Threading;
using System.Threading.Tasks;

namespace GestionColegio.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAsignaturaRepository AsignaturaRepository { get; }
        IProfesorRepository ProfesorRepository { get; }
        IEstudianteRepository EstudianteRepository { get; }
        Task<int> CompleteAsync();
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
