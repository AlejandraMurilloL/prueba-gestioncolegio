using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using GestionColegio.Persistence.EntityFramework.Context;

namespace GestionColegio.Persistence.EntityFramework.Repositories
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        public EstudianteRepository(GestionColegioDbContext context) : base(context)
        {

        }
    }
}
